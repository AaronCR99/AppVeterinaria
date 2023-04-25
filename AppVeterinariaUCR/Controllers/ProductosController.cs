using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Librerias importadas
/// </summary>

using AppVeterinariaUCR.Models; // Utilizar los objetos
using AppVeterinariaUCR.Data;
using Microsoft.EntityFrameworkCore; // Utilizar el ORM
using Microsoft.AspNetCore.Http;
using System.IO; // Se utiliza para las fotos

//importacion de librerias
using System.Net.Http;
using Newtonsoft.Json;


namespace AppVeterinariaUCR.Controllers
{
	public class ProductosController : Controller
	{
		//Variable para manejar la información del productos
		private Productos productos;

		//variable para manejar la referencia del contexto
		//ORM  Entity Framework     Object  =  Entidad Table =  CRUD
		private VeterinariaContext context;

		/// <summary>
		/// Las siguientes variables son para el cambio del dolar
		/// </summary>

		// varaible para manejar la conexion con la API.
		private TipoCambioAPI api;

		// VARIABLE PARA MENEJAR LA INSTANCIA DEL OBJETO JSON
		public static TipoCambio varTipoCambio;

		/// Programado el 10/05/2021 hora 15:47
		private static string fotoAnterior = "";

		//Constructor  con parámetros, recibe la referencia del contexto
		public ProductosController(VeterinariaContext cnt)
		{
			this.context = cnt;

			this.extraerTipoCambio();
		}

		/// <summary>
		/// Método encargado de mostrar la lista de productos
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			//con el método toListAsync() se obtiene el listado de productos por medio del ORM
			return View(await this.context.Productos.ToListAsync());
		}

		/// <summary>
		/// Action encargado de mostrar el formulario para incluir un producto
		/// </summary>
		/// <returns></returns>
		/// //Este verbo permite mostrar la información del front-end al usuario
		[HttpGet]
		public IActionResult Crear()
		{
			return View();
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Crear(
			List<IFormFile> files,
		 [Bind("Id,Descrip,PrecioCompra,PorImp,Foto,Estado,FechaRegistro")] Productos productos)
		{
			if (ModelState.IsValid)
			{

				//variable para definir la ruta fisica donde se almacenan las fotos
				//se toma el directorio base donde se encuentra la aplicacion Web
				//string rutaFisica = AppDomain.CurrentDomain.BaseDirectory;

				//se toma  de la ruta  la carpeta del  proyecto
				//string filePath = rutaFisica.Substring(0, rutaFisica.Length - 24);

				//aqui se indica el folder ProductosFotos para almacenar las fotos
				string filePath = @"wwwroot\css\img\ProductosFotos\";

				//variable para almacenar el nombre del archivo
				string fileName = "";

				//se recorre los archivos adjunto a nivel del formulario
				foreach (var formFile in files)
				{
					//se valida el tamaño del archivo
					if (formFile.Length > 0)
					{
						//se construye el nombre de la foto con el código producto
						fileName = productos.Id + "_" + formFile.FileName;

						//aquí se quitan los espacios en blanco dentro del nombre de la foto
						fileName = fileName.Replace(" ", "_");

						//en la ruta fisica se agrega el nombre de la foto
						filePath += fileName;

						using (var stream = new FileStream(filePath, FileMode.Create))
						{
							await formFile.CopyToAsync(stream);
							//ahora le indicamos en nuestra db donde está la foto
							productos.Foto = "/css/img/ProductosFotos/" + fileName;
						} //cierre using
					}//cierre del if
				}//cierre del foreach


				//datos por default del producto
				productos.Estado = 'A';
				productos.FechaRegistro = DateTime.Now;

				//se guarda el producto a nivel de contexto
				context.Add(productos);

				//aplique los cambios en la DB
				await context.SaveChangesAsync();

				//Se redirecciona al usuario en la lista de productos
				return RedirectToAction(nameof(Index));



			}//cierre del if validación del modelo

			return View(productos);
		} //cierre del método POST  crear

		/// <summary>
		/// Metodo encargado de leer todos los productos en la db
		/// y enviar los datos al view mostrando la informacion
		/// </summary>
		/// <returns></returns>
		[HttpGet] // Verbo para estraer informacion
		public async Task<IActionResult> GaleryProductos()
		{
			return View(await this.context.Productos.ToListAsync()); // Aqui es para enviar las imagenes a la view //
		}

		// programacion del dia 06/05/2021 hora 10:25am

		private async void extraerTipoCambio()
		{
			//reglas de negocio
			try
			{ //Intento de conexion con la API
			  // se crea una instancia de la API
				this.api = new TipoCambioAPI();

				// Se obtiene el objeto client para consumir la API
				HttpClient client = this.api.Inicial();

				// Aqui se utiliza el metodo publico de la API de gometa
				HttpResponseMessage response = await client.GetAsync("tdc/tdc.json");

				if (response.IsSuccessStatusCode)
				{
					// aqui se lee los datos obtenidos del objeto JSON
					var result = response.Content.ReadAsStringAsync().Result;

					// se convierte el objeto JSON al objeto TipoCambio del model
					varTipoCambio = JsonConvert.DeserializeObject<TipoCambio>(result);
				}
			} // En caso de error capturamos el error con la ex
			catch (Exception ex)
			{
				throw;
			}
		}

		//Programacion del 10/05/2021 Hora 14:09 de aqui para abajo
		//**********************************************************************************************//
		[HttpGet]
		public async Task<IActionResult> Modificar(int? id)
		{
			// Se pregunta si el id tiene datos
			if (id == null)
			{
				return NotFound();
			}
			// se busca el objeto a modificar por medio de su Id
			var producto = await this.context.Productos.FindAsync(id);
			// se pregunta si la variable productos tiene datos
			if (producto == null)
			{
				return NotFound();
			}
			// aqui almacenamos el nombre de la foto anterior
			fotoAnterior = producto.Foto;

			// aqui se envia el objeto a nuestra vista
			return View(producto);
		}

		//**********************************************************************************************//

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Modificar(int id,
			[Bind("Id,Descrip,PrecioCompra,PorImp,Foto,Estado,FechaRegistro")]Productos productos,
            List<IFormFile> files)
        {
			// se valida el Id del producto a modificar
			if(id != productos.Id)
            {
				return NotFound();
            }
			// aqui se valida el objeto modelo
            if (ModelState.IsValid)
            {
				// se intenta realizar la modificacion
                try
                {
					// datos por default al producto
					productos.Estado = 'A';
					productos.FechaRegistro = DateTime.Now;

					// se toma la ruta para borrar la foto anterior
					string filePath = this.rutaFisicaBorrar();

					// Aqui se indica el nombre de la foto anterior a borrar
					filePath += fotoAnterior;

					// Aqui se borra la foto anterior
					this.borrarFoto(filePath);

					// Aqui indicamos la ruta donde se guarda la nueva foto
					filePath = this.rutaFisicaGuardar();

					// variable para almacenar el nombre de la foto
					string fileName = "";

                    // Se revisa si el formulario tiene fotos adjuntas
                    foreach (var item in files)
                    {
                        // se valida el tamano del adjunto
                        if (item.Length > 0)
                        {
							// Aqui asignamos el id del producto con su nombre de foto
							fileName = productos.Id + "_" + item.FileName;

							// En caso que tenga espacios en blanco, lo quitamos
							fileName = fileName.Replace(" ","_");

							// Aqui indicamos el nombre de la nueva foto aguardar
							filePath += fileName;

                            // Se crea el objeto para almacenar la foto
                            using (var stream = new  FileStream(filePath, FileMode.Create))
                            {
								// Aqui esperamos que se copie la nueva foto
								await item.CopyToAsync(stream);

								// Aqui se indica el nombre de la nueva foto
								productos.Foto = "/css/img/ProductosFotos/" + fileName;
                            } // Cierre del using
                        } // Cierre del if sobre el tamano del archivo
                    }//Cierre del foreach

					// guardamos el producto
					this.context.Productos.Update(productos);

					// Esperamos que se apliquen los cambios
					await this.context.SaveChangesAsync();
				}// se controla durante la modificacion
                catch (DbUpdateConcurrencyException ex)
                {
					// se pregunta si fue que el producto no existe
                    if (! this.ExisteProducto(id))
                    {
						return NotFound();
                    }
                    else
                    {
						throw ex;
                    }
                } // Cierre del catch

				return RedirectToAction(nameof(Index));

            } // CIERRE DEL IF MODEL
			return View(productos);
        }// CIERRE DEL METODO

		//*********************************************************************************************//

		private string rutaFisicaBorrar()
        {
			// Se toma el directorio base donde se ejecuta la aplicacion
			//string rutaFisica = AppDomain.CurrentDomain.BaseDirectory;

			// Aqui ubicamos el directorio en la carpeta de los paquetes de la aplicacion
			//string filePath = rutaFisica.Substring(0, rutaFisica.Length - 24);

			// como borramos debemos cambiar el caracter \ por /
			//filePath = filePath.Replace(@"\", "/");

			// Aqui se indica el folder de productos, se debe de borrar las fotos
			string filePath = @"wwwroot";

			// se retorna la ruta donde se borra
			return filePath;
        } // Cierre del rutaFisicaBorrar //

		//****************************************************************************************//

		private String rutaFisicaGuardar()
        {
			// Se toma el directorio base donde se ejecuta la aplicacion
			//string rutaFisica = AppDomain.CurrentDomain.BaseDirectory;

			// Aqui ubicamos el directorio en la carpeta de los paquetes de la aplicacion
			//string filePath = rutaFisica.Substring(0, rutaFisica.Length - 24);

			// Aqui se indica donde se deben de guardar las fotos
			string filePath = @"wwwroot\css\img\ProductosFotos\";

			return filePath;
		}

		//***************************************************************************************//

		private void borrarFoto(string pFileName)
        {
            try
            {
				//Aqui se borra la foto anterior del producto
				System.IO.File.Delete(pFileName);
			}
            catch (Exception)
            {

                
            }
			
        }

		//***************************************************************************************//

		public bool ExisteProducto(int pId)
        {
			//Revisamos si existe el producto
			return this.context.Productos.Any(prod => (prod.Id == pId));
        }


		//************************************************************************************************//

		//Programacion del 13/05/2021 08:42 Creacion Eliminar 
		//Metodo eliminar

		[HttpGet]
		public async Task<IActionResult> Eliminar(int? id)
		{
			//se pregunta si Id viene nulo
            if (id == null)
            {
				return NotFound();
            }

			//Expresiones lambda (p => p.Id == id); utilizando FirstOrDefaultAsync del ORM 
			var producto = await this.context.Productos.FirstOrDefaultAsync(p => p.Id == id);

			//Preguntamos si productos tiene datos  
            if (producto == null)
            {
				return NotFound();
            }

			return View(producto);

		}//Fin Metodo Eliminar

		[HttpPost, ActionName("Eliminar")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> EliminarConfirmacion(int id)
		{
			var product = await this.context.Productos.FindAsync(id);

            if (product != null)
            {
				this.context.Productos.Remove(product);
				await this.context.SaveChangesAsync();
            }

			return RedirectToAction(nameof(Index));
		}// Fin eliminar Post




	}//cierre de clase
}//cierre de namespace
