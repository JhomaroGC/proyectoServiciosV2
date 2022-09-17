using Microsoft.EntityFrameworkCore;
using ProyectoServicios.App.Dominio.Entidades; //Es posible que debamos incluir el espacio de nombre: Entidades

namespace ProyectoServicios.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BDProyectoServicios"
                );
            }
        }
    }
}
