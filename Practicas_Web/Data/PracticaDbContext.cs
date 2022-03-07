using Microsoft.EntityFrameworkCore;
using Practicas_Web.Models;
using System.Collections.Generic;

namespace Practicas_Web.Data
{
    public class PracticaDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseMySQL(
                "server=localhost;database=practica;user=root;");
        }


        public DbSet<CantonesModel> Canton { get; set; }
        public DbSet<CuentaModel> Datos { get; set; }
    }
}
