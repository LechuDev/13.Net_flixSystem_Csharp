using NetFlixSys.Data;
using NetFlixSys.Models;
using System.Collections.Generic;
using System.Linq;


namespace NetFlixSys.Services
{
    public class RecomendacionService
    {
        private readonly AppDbContext _context;

        public RecomendacionService(AppDbContext context)
        {
            _context = context;
        }

        public List<Pelicula> ObtenerRecomendaciones(int usuarioId)
        {
            var preferencias = _context.Preferencias
                .Where(p => p.UsuarioId == usuarioId)
                .Select(p => p.Genero)
                .ToList();

            var sugerencias = _context.Peliculas
                .Where(p => preferencias.Contains(p.Genero))
                .ToList();

            return sugerencias;
        }
    }
}