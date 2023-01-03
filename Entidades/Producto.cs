using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Entidades
{
    public class Producto
    {
        [Key]        
        public int ProductoID { get; set; }
        [Required]
        [StringLength(6)]
        public string Codigo { get; set; }
        [StringLength(200)]
        public string Descripcion { get; set; }
        public int CantidadTotal { get; set; }
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
        public ICollection<Storage> Storages { get; set; }
    }
}
