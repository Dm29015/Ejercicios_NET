using System.ComponentModel.DataAnnotations.Schema;

namespace ComerciPlus.Models
{
    public class Credito
    {
        [Key]
        public int Id { get; set; }
        public decimal DeudaTotal { get; set; }
        public decimal DeudaActual { get; set; }
        public decimal AbonosTotal { get; set;}
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente? Cliente { get; set; }
    }
}
