using Friends.Dados;
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
        private readonly ApplicationContext applicationContext;

        public GerenciarTemporadaController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var temporadas = applicationContext.Temporadas;
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

        public IActionResult Editar(Temporada temporada)
        {
            
            return View();
        }
    }
}
