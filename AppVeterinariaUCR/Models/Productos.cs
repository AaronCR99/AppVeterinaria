using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVeterinariaUCR.Models
{
	public class Productos
	{
		public int Id { get; set; }

		public string Descrip { get; set; }

		public decimal PrecioCompra { get; set; }

		//Porcentaje de impuesto del IVA
		public decimal PorImp { get; set; }

		public string Foto { get; set; }
		public char Estado { get; set; }

		public DateTime FechaRegistro { get; set; }
	}
}
