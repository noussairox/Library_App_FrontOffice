using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Membre
    {
        [Key]
        public int MembreId { get; set; }

        [Required(ErrorMessage = "Le prénom est requis.")]
        public string? Prenom { get; set; }

        [Required(ErrorMessage = "Le nom est requis.")]
        public string? Nom { get; set; }

        public string? Adresse { get; set; }

        [Required(ErrorMessage = "Le numéro de téléphone est requis.")]
        public string? NumeroTelephone { get; set; }

        [EmailAddress(ErrorMessage = "L'e-mail n'est pas dans un format valide.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "La date d'inscription est requise.")]
        public DateTime? DateInscription { get; set; } = DateTime.Now;
    }
}
