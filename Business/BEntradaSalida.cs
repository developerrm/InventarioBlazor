using DataAccess;
using Entidades;

namespace Business
{
    public class BEntradaSalida
    {
        private readonly DataContext context;
        public List<EntradaSalida> EntradaSalidaList()
        {
            using (var db = new DataContext())
            {
                return context.TEntradaSalida.ToList();
            }



        }
        public void Create(EntradaSalida entradaSalida)
        {
            using (var db = new DataContext())
            {
                context.TEntradaSalida.Add(entradaSalida);
                context.SaveChanges();
            }

        }
        public void Update(EntradaSalida entradaSalida)
        {
            using (var db = new DataContext())
            {
                context.TEntradaSalida.Update(entradaSalida);
                context.SaveChanges();
            }

        }
    }
}
