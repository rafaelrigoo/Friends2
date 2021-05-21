using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Friends.Models;
using Friends.Dados;
using Microsoft.EntityFrameworkCore;

namespace Friends.Controllers
{
    public class TemporadasController : Controller
    {

        private readonly ApplicationContext _context;

        public TemporadasController(ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Listar as temporadas da série
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var temporadas = _context.Temporadas;

            return View(temporadas);
        }

        public IActionResult Episodios(byte numeroTemporada)
        {
            ViewData["NumeroTemporada"] = numeroTemporada;

            var episodio = _context.Episodios
                .Include(t => t.Temporada)
                .Where(e => e.Temporada.Numero == numeroTemporada)
                .OrderBy(d => d.QuandoFoiLancado);
                
            return View(episodio);
        }

    }
}
