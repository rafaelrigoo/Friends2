using Friends.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class GerenciarTemporadaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            var temporada1 = new Temporada(1);
            temporada1.CaminhoImagem = "/imagens/temporada1capa.jpg";

            var temporada2 = new Temporada(2);
            temporada2.CaminhoImagem = "/imagens/temporada2capa.jpg";

            var temporada3 = new Temporada(3);
            temporada3.CaminhoImagem = "/imagens/temporada3novacapa.jpg";

            var temporada4 = new Temporada(4);
            temporada4.CaminhoImagem = "/imagens/temporada4capa.jpg";

            var temporada5 = new Temporada(5);
            temporada5.CaminhoImagem = "/imagens/temporada5capanova.jpg";

            var temporadas = new List<Temporada>
            {
                temporada1, temporada2, temporada3, temporada4, temporada5
            };

            return View(temporadas);
            
        }


        [HttpGet]
        public IActionResult Temporada()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Temporada(Temporada temporada)
        {
            if (ModelState.IsValid)
            {
                return Json(temporada);
            }

            return View(temporada);
        }
    }
}
