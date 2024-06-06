namespace ComerciPlus.Models
{
#pragma warning disable CS8981 // El nombre de tipo solo contiene caracteres ASCII en minúsculas. Estos nombres pueden reservarse para el idioma.
    public class clientes
#pragma warning restore CS8981 // El nombre de tipo solo contiene caracteres ASCII en minúsculas. Estos nombres pueden reservarse para el idioma.
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El número de identificación es obligatorio.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El número de identificación debe contener solo números.")]
        public string? CedulaCliente { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        [MaxLength(30, ErrorMessage = "El nombre del cliente no puede superar los 30 caracteres.")]
        public string? NombreCliente { get; set; }

        [Required(ErrorMessage = "El apellido del cliente es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El apellido del cliente no puede superar los 50 caracteres.")]
        public string? ApellidoCliente { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        [MaxLength(200, ErrorMessage = "La dirección no puede superar los 200 caracteres.")]
        public string? DireccionCliente { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El teléfono debe contener solo números.")]
        [MaxLength(10, ErrorMessage = "El teléfono no puede superar los 10 caracteres.")]
        public string? TelefonoCliente {  get; set; }

        [Required]
        public bool EstadoCliente { get; set; }
        
    }
}
