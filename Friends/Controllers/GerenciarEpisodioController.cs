using Friends.Dados;
using Friends.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class GerenciarEpisodioController : Controller // CRUD - Create, Retrieve, Update, Delete
    {
        private readonly ApplicationContext applicationContext;

        public GerenciarEpisodioController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var episodios = applicationContext.Temporadas;
            return View(episodios);
        }


        public IActionResult IndexForm(Temporada temporada)
        {
            var episodios = applicationContext.Temporadas
                .Include(ep => ep.Episodios)
                .Where(ep => ep.Numero == temporada.Numero);
                
            return View(episodios);
        }

        [HttpGet]
        public IActionResult Episodio()  // formulário para preencher os dados de episódio
        {
            return View();
        }

        [HttpPost]
        public IActionResult Episodio(Episodio episodio) // recebe os dados de um episódio enviados pelo formulário, e salva no banco
        {
            if (ModelState.IsValid)
            {
                return Json(episodio);
            }

            return View(episodio);
        }

        public IActionResult ExcluirEpisodio(Episodio episodio)
        {
            var ep = applicationContext.Episodios
                .Include(e => e.Nome == episodio.Nome);

            applicationContext.Remove(ep);

            applicationContext.SaveChanges();

            return View();
        }


    }
}
