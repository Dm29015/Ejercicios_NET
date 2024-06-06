using System.ComponentModel.DataAnnotations;

namespace ComerciPlus.Models
{
#pragma warning disable CS8981 // El nombre de tipo solo contiene caracteres ASCII en minúsculas. Estos nombres pueden reservarse para el idioma.
    public class proveedores
#pragma warning restore CS8981 // El nombre de tipo solo contiene caracteres ASCII en minúsculas. Estos nombres pueden reservarse para el idioma.
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El NIT es obligatorio.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El NIT debe contener solo números.")]
        public string? nit { get; set; }

        [Required(ErrorMessage = "El nombre de la empresa es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El nombre de la empresa no puede superar los 100 caracteres.")]
        public string? nombreEmpresa { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        [MaxLength(200, ErrorMessage = "La dirección no puede superar los 200 caracteres.")]
        public string? direccionEmpresa { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El teléfono debe contener solo números.")]
        [MaxLength(10, ErrorMessage = "El teléfono no puede superar los 10 caracteres.")]
        public string? telefonoEmpresa { get; set; }

        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "El nombre del vendedor debe contener solo letras y espacios.")]
        [MaxLength(100, ErrorMessage = "El nombre del vendedor no puede superar los 100 caracteres.")]
        public string? nombreVendedor { get; set; }


    }
}


