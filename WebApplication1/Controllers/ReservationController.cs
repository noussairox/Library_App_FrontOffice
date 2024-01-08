using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservationController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public IActionResult Confirmer(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                // Ajouter l'instance de Reservation au contexte
                _context.Reservations.Add(reservation);

                // Enregistrer les modifications dans la base de données
                _context.SaveChanges();

                // Récupérer le livre associé à la réservation
                var livre = _context.Livres.Find(reservation.LivreId);

                if (livre != null)
                {
                    // Décrémenter la quantité disponible
                    livre.QuantiteDisponible--;

                    // Sauvegarder les modifications du livre dans la base de données
                    _context.SaveChanges();
                }

                // Rediriger vers une action appropriée après la réservation
                return RedirectToAction("ReservationSuccess",new { reservationId = reservation.Id });
            }

            // Si le modèle n'est pas valide, revenir à la vue des détails du livre avec le modèle réservation pour afficher les erreurs
            return RedirectToAction("Details", "Livre", new { id = reservation.LivreId, erreur = true });
        }
        public IActionResult ReservationSuccess(int reservationId)
        {
            return View();
        }

    }

}
