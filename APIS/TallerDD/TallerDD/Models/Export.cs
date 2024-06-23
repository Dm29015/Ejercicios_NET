namespace TallerDD.Models
{
    public class Export
    {
        [Key]
        public int IdExport { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Solo debe contener letras y espacios.")]
        [MaxLength(100, ErrorMessage = "Cantidad máxima de caracteres.")]
        public required string Name { get; set; }

        [Required]
        public required string Kg { get; set; }

        [Required]
        public required string PriceDollar { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }
        
        
    }
}
