using Entidades;
using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class DataContext : DbContext
    {
        public DbSet<Producto> TProducto { get; set; }
        public DbSet<Categoria> TCategoria { get; set; }
        public DbSet<Bodega> TBodega { get; set; }
        public DbSet<EntradaSalida> TEntradaSalida { get; set; }
        public DbSet<Storage> TStorage { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=SERVER-R;DataBase=InventarioDB;User=sa;Password=listosoft01@;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Categoria>().HasData(
                new Categoria() { CategoriaID=1,Descripcion="Aseo Hogar"}
                );
            builder.Entity<Bodega>().HasData(
                new Bodega() { BodegaID=1,Nombre="Principal",Direccion="Los Esteros"}
            );
        }
    }
}