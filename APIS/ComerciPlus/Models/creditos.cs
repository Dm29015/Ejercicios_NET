using System.ComponentModel.DataAnnotations.Schema;

namespace ComerciPlus.Models
{
#pragma warning disable CS8981 // El nombre de tipo solo contiene caracteres ASCII en minúsculas. Estos nombres pueden reservarse para el idioma.
    public class creditos
#pragma warning restore CS8981 // El nombre de tipo solo contiene caracteres ASCII en minúsculas. Estos nombres pueden reservarse para el idioma.
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal DeudaTotal { get; set; }
        public decimal DeudaActual { get; set; }
        public decimal AbonosTotal { get; set;}
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public clientes? Cliente { get; set; }
    }
}
