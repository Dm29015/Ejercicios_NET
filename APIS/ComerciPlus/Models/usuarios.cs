namespace ComerciPlus.Models
{
#pragma warning disable CS8981 // El nombre de tipo solo contiene caracteres ASCII en minúsculas. Estos nombres pueden reservarse para el idioma.
    public class usuarios
#pragma warning restore CS8981 // El nombre de tipo solo contiene caracteres ASCII en minúsculas. Estos nombres pueden reservarse para el idioma.
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Correo { get; set; }

        [Required]
        public string? Clave { get; set; }
       
    }
}
