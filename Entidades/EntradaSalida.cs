using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Entidades
{
    public class EntradaSalida
    {
        [Key]        
        public int EntradaSalidaID { get; set; }
        [Required]
        public DateTime FechaInOut { get; set; }
        [Required]        
        public int Cantidad { get; set; }
        [Required]
        public bool EsEntrada { get; set; }
        public int StorageID { get; set; }
        public Storage Storage { get; set; }
    }
}
