using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GamingZoneApp.Data;
using GamingZoneApp.Models;

namespace GamingZoneApp.Controllers
{
    public class ArticuloController : Controller
    {
        public IActionResult Index()
        {
            return View(ArticuloRepository.ObtenerArticulos());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Articulo articulo)
        {
            if (ArticuloRepository.CodigoExiste(articulo.CodigoInterno))
            {
                ModelState.AddModelError("CodigoInterno", "El código interno ya existe");
            }

            if (articulo.AnioLanzamiento > DateTime.Now.Year)
            {
                ModelState.AddModelError("AnioLanzamiento", "El año no puede ser futuro");
            }

            if (!ModelState.IsValid)
            {
                return View(articulo);
            }

            ArticuloRepository.AgregarArticulo(articulo);
            TempData["Mensaje"] = "Artículo registrado correctamente";

            return RedirectToAction(nameof(Index));
        }
    }
}