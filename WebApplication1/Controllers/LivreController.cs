using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LivreController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LivreController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var livres = _context.Livres.ToList();
            return View(livres);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var livre = _context.Livres.Find(id);

            if (livre == null)
            {
                return NotFound();
            }

            var reservationViewModel = new LivreReservationViewModel
            {
                Livre = livre,
                Reservation = new Reservation(),
                // Initialisez les autres propriétés nécessaires ici
            };

            return View(reservationViewModel);
        }

    }
}
