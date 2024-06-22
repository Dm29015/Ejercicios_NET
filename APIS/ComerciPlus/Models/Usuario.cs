using System.ComponentModel.DataAnnotations;

namespace ComerciPlus.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 carácteres.")]
        public string? NombreCompleto { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "El correo no tiene un formato válido.")]
        [EmailAddress(ErrorMessage = "El correo no tiene un formato válido.")]
        public required string Correo { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "La contraseña debe ser mayor a 5 caracteres.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{5,}$", ErrorMessage = "La contraseña debe contener al menos una letra mayúscula, una letra minúscula y un número.")]
        public required string Clave { get; set; }

        [Phone(ErrorMessage = "El teléfono no tiene un formato válido.")]
        public string? Telefono { get; set; }
    }
}
