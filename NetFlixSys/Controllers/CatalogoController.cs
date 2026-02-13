using Microsoft.AspNetCore.Mvc;
using NetFlixSys.Data;
using NetFlixSys.Models;
using System.Linq;
using System.Collections.Generic;


namespace NetFlixSys.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly AppDbContext _context;

        public CatalogoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var peliculas = _context.Peliculas.ToList();
            return View(peliculas);
        }

        public IActionResult Detalles(int id)
        {
            var pelicula = _context.Peliculas.FirstOrDefault(p => p.Id == id);
            if (pelicula == null) return NotFound();
            return View(pelicula);
        }
    }
}