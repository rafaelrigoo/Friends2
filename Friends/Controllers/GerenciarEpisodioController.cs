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

        [HttpGet]
        public IActionResult Index()
        {

            var temporada1 = new Temporada(1);
            temporada1.QuandoFoiLancada = new DateTime(1994, 06, 01);
            temporada1.QuandoTerminou = new DateTime(1995, 06, 01);
            var episodio1 = new Episodio("The Pilot", temporada1);
            var episodio2 = new Episodio("The Storm", temporada1);
            temporada1.Episodios.Add(episodio1);
            temporada1.Episodios.Add(episodio2);


            var temporada2 = new Temporada(2);
            var episodio3 = new Episodio("The Pillow", temporada2);
            var episodio4 = new Episodio("The Mouse", temporada2);
            temporada2.QuandoFoiLancada = new DateTime(1995, 06, 01);
            temporada2.QuandoTerminou = new DateTime(1996, 06, 01);
            temporada2.Episodios.Add(episodio3);
            temporada2.Episodios.Add(episodio4);


            var temporada3 = new Temporada(3);
            var episodio5 = new Episodio("The 111", temporada3);
            var episodio6 = new Episodio("The kkk", temporada3);
            temporada3.QuandoFoiLancada = new DateTime(1996, 06, 01);
            temporada3.QuandoTerminou = new DateTime(1997, 06, 01);
            temporada3.Episodios.Add(episodio5);
            temporada3.Episodios.Add(episodio6);

            var lista = new List<Temporada>() { temporada1, temporada2, temporada3};

            return View(lista);
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


    }
}
