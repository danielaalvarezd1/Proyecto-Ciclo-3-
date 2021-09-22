using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Encomienda> Encomiendas { get; set; }
        public Dbset <Usuario> Usuarios { get; set; }
        public Dbset <Servicio> Servicios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source =(172.19.14.201) (localdb)\\MSSQLLocalDB; Initial Catalog = ProyectoCiclo3Amazon");
            }
        }
    }
}
