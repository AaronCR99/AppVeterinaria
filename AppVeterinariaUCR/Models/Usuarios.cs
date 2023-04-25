using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppVeterinariaUCR.Models
{
    public class Usuarios
    {
        [Key]
        public string Login { get; set; }

        public string Nombre { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

    }
}
