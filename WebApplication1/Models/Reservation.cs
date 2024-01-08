using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime? DateReservation { get; set; }

        [Required]
        public string? NomEmprunteur { get; set; }

        [Required]
        public string? Cin { get; set; }

        [Required]
        public bool? EstEmprunte { get; set; }

        [Required]
        public int? LivreId { get; set; } 

        public Livre? Livre { get; set; }
    }
}
