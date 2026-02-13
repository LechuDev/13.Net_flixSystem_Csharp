using Microsoft.AspNetCore.Mvc;
using NetFlixSys.Data;
using NetFlixSys.Services;

namespace NetFlixSys.Controllers
{
    public class RecomendacionesController : Controller
    {
        private readonly RecomendacionService _service;

        public RecomendacionesController(RecomendacionService service)
        {
            _service = service;
        }

        public IActionResult Sugerencias(int usuarioId)
        {
            var sugerencias = _service.ObtenerRecomendaciones(usuarioId);
            return View(sugerencias);
        }
    }
}