using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppVeterinariaUCR.Models;

namespace AppVeterinariaUCR.Data
{
    public class VeterinariaContext : DbContext
    {
        public VeterinariaContext (DbContextOptions<VeterinariaContext> options)
            : base(options)
        {
        }
        //Estos contexto son  utilizados por EntityFramework para interactuar con la db
        //Contexto para manejar las referencias de las mascotas
        public DbSet<AppVeterinariaUCR.Models.Mascotas> Mascotas { get; set; }

        //Contexto para manejar las referencias de los productos
        public DbSet<AppVeterinariaUCR.Models.Productos> Productos { get; set; }

        //Contexto para manejar las referencias de los usuarios
        public DbSet<AppVeterinariaUCR.Models.Usuarios> Usuarios { get; set; }

    }
}
