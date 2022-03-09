using Microsoft.EntityFrameworkCore;
using Practicas_Web.Models;

namespace Practicas_Web.Data
{
    public class PracticaDbContext : DbContext
    {

        public PracticaDbContext(DbContextOptions<PracticaDbContext> options)
            : base (options)
        {

        }

        public DbSet<CantonesModel> Canton { get; set; }
        public DbSet<CuentaModel> Datos { get; set; }
    }
}
