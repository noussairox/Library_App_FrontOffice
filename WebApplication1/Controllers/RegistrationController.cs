using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistrationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult InscriptionAdherent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InscriptionAdherent(Membre membre)
        {
            if (ModelState.IsValid)
            {
                // Enregistrez les données d'inscription dans la base de données ou effectuez d'autres actions nécessaires
                _context.Membres.Add(membre);
                _context.SaveChanges();

                // Redirigez vers une page de confirmation ou une autre page appropriée
                return RedirectToAction("ConfirmationInscription");
            }

            // Si le modèle n'est pas valide, revenez à la vue d'inscription avec les erreurs
            return View(membre);
        }

        public IActionResult ConfirmationInscription()
        {
            return View();
        }
    }
}
