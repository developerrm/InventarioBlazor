using DataAccess;
using Entidades;

namespace Business
{
    public class BCategoria
    {
        private readonly DataContext context;
        public static List<Categoria> CategoriaList()
        {
            using (var context = new DataContext())
            {
                return context.TCategoria.ToList();
            }

        }
        public static void Create(Categoria categoria)
        {
            using (var context = new DataContext())
            {
                context.TCategoria.Add(categoria);
                context.SaveChanges();
            }
            
        }
        public static void Update(Categoria categoria)
        {
            using (var context = new DataContext())
            {
                context.TCategoria.Update(categoria);
                context.SaveChanges();
            }
            
        }
    }

}