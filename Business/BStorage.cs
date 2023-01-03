using DataAccess;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class BStorage
    {
        private readonly DataContext context;
        public static List<Storage> StorageList()
        {
            //FORMA 1
            using (var db = new DataContext())
            {
                return db.TStorage.Include(x=>x.Producto).ToList();
            }
            //FORMA 2
            //return context.TStorage.ToList();
        }
        public static List<Storage> StorageByBodegaID(string bodegaID)
        {
            //FORMA 1
            using (var db = new DataContext())
            {
                return db.TStorage.Where(x => x.BodegaID.ToString() == bodegaID).Include(x => x.Producto).ToList();
            }
        }
        public static void Create(Storage storage)
        {

            using (var context = new DataContext())
            {

                context.TStorage.Add(storage);
                context.SaveChanges();
            }

        }
        public static void Update(Storage storage)
        {
            using (var context = new DataContext())
            {
                context.TStorage.Update(storage);
                context.SaveChanges();
            }

        }
        public static bool EstaProductoEnAlmacenamiento(string bodegaID, string productoID)
        {
            using (var context = new DataContext())
            {
                var producto = context.TStorage.ToList().Where(x => x.BodegaID.ToString() == bodegaID && x.ProductoID.ToString() == productoID);
                return producto.Any();

            }
        }
    }
}