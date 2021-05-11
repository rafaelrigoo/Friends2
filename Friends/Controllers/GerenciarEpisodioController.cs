using Friends.Dados;
using Friends.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
            var episodios = applicationContext.Episodios;
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
            applicationContext.Episodios.Remove(episodio);
            applicationContext.SaveChanges();

            return View();
        }


    }
}
