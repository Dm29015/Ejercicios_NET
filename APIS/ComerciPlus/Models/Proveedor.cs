using System.ComponentModel.DataAnnotations;

namespace ComerciPlus.Models
{
    public class Proveedor

    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El NIT es obligatorio.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El NIT debe contener solo números.")]
        public string? Nit { get; set; }

        [Required(ErrorMessage = "El nombre de la empresa es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El nombre de la empresa no puede superar los 100 caracteres.")]
        public string? NombreEmpresa { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        [MaxLength(200, ErrorMessage = "La dirección no puede superar los 200 caracteres.")]
        public string? DireccionEmpresa { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El teléfono debe contener solo números.")]
        [MaxLength(10, ErrorMessage = "El teléfono no puede superar los 10 caracteres.")]
        public string? TelefonoEmpresa { get; set; }

        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "El nombre del vendedor debe contener solo letras y espacios.")]
        [MaxLength(100, ErrorMessage = "El nombre del vendedor no puede superar los 100 caracteres.")]
        public string? NombreVendedor { get; set; }


    }
}


