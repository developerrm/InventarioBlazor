using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Entidades
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}
