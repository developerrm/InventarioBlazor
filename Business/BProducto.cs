using DataAccess;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class BProducto
    {
        //private readonly DataContext context;
        public static List<Producto> ProductoList()
        {
            using (var context = new DataContext())
            {
                return context.TProducto.Include(x=>x.Categoria).ToList();
            }
        }
        public static Producto GetProductoByID(int productoID)
        {
            using (var context = new DataContext())
            {
                return context.TProducto.Include(x => x.Categoria).Where(x => x.ProductoID == productoID).FirstOrDefault();
            }
        }
        public static void Create(Producto producto)
        {
            using (var context = new DataContext())
            { 
                context.TProducto.Add(producto);
                context.SaveChanges();
            }
            //  context.TProducto.Add(producto);
            //context.SaveChanges();
        }
        public static void Update(Producto producto)
        {
            using (var context = new DataContext())
            {

                context.TProducto.Update(producto);
                context.SaveChanges();
            }
        }
    }

}