using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Entidades
{
    public class Storage
    {
        [Key]        
        public int StorageID { get; set; }
        [Required]
        public DateTime FechaActualizacion { get; set; }
        [Required]        
        public int CantidadParcial { get; set; }
        public int ProductoID { get; set; }
        public Producto Producto { get; set; }
        public int BodegaID { get; set; }
        public Bodega Bodega { get; set; }
        public ICollection<EntradaSalida> EntradasSalidas { get; set; }
    }
}
