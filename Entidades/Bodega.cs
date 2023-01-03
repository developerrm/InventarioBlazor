using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Entidades
{
    public class Bodega
    {
        [Key]        
        public int BodegaID { get; set; }
        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(200)]
        public string Direccion { get; set; }
        public ICollection<Storage> Storages { get; set; }
    }
}
