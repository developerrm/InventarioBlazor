using DataAccess;
using Entidades;
using Microsoft.Identity.Client.Extensions.Msal;

namespace Business
{
    public class BBodega
    {
        private readonly DataContext context;
        public static List<Bodega> BodegaList()
        {
            using (var context = new DataContext())
            {
                return context.TBodega.ToList();
            }
           
        }
        public static void Create(Bodega bodega)
        {
            using (var context = new DataContext())
            {
                context.TBodega.Add(bodega);
                context.SaveChanges();
            }
            
        }
        public static void Update(Bodega bodega)
        {
            using (var context = new DataContext())
            {
                context.TBodega.Update(bodega);
                context.SaveChanges();
            }
            
        }

    }
}