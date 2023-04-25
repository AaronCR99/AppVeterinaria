using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVeterinariaUCR.Models
{
	public class Mascotas
	{

		//propiedades set  y  get  para cada atributo
		public int id { get; set; }

		public string nombre { get; set; }

		public DateTime fechaIngreso { get; set; }

		public decimal peso { get; set; }

		public string raza { get; set; }

		public char estado { get; set; }


	}//cierre de clase
} //cierre de namespace
