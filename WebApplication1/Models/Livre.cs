using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
    public class Livre
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le titre du livre est requis.")]
        public string? Titre { get; set; }

        [Required(ErrorMessage = "Le nom de l'auteur est requis.")]
        public string? Auteur { get; set; }

        [Required(ErrorMessage = "Le numéro ISBN est requis.")]
        public string? ISBN { get; set; }

        [Required(ErrorMessage = "La date de publication est requise.")]
        public DateTime? DatePublication { get; set; }

        [Required(ErrorMessage = "La quantité disponible est requise.")]
        public int? QuantiteDisponible { get; set; }

        public byte[]? Image { get; set; } // Pour stocker l'image en tant que tableau de bytes

        
    }
}
