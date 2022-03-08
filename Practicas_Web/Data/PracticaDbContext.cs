using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Sqlite;
using Practicas_Web.Models;

namespace Practicas_Web.Data
{
    public class PracticaDbContext : DbContext
    {

        public PracticaDbContext(DbContextOptions<PracticaDbContext> options)
            : base (options)
        {

        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        //{


        //    optionsBuilder.UseMySQL(
        //        "");

        //    //optionsBuilder.UseSqlServer();

        //    //optionsBuilder.UseSqlite();
        //}


        public DbSet<CantonesModel> Canton { get; set; }
        public DbSet<CuentaModel> Datos { get; set; }
    }
}
