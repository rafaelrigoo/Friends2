using Friends.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class EpisodioController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ParticipacaoEspecial()
        {
            var episodio1 = new Episodio("The Pilot", new Temporada(1));
            // episodio1.ParticipacaoEspecial.NomeReal = "Bruce Willians";
            // episodio1.ParticipacaoEspecial.Personagem = "Paul Stevens";

            return View(episodio1);
        }

        public IActionResult AdicionarEpisodios(Episodio episodio)
        {
            return View();
        }
    }
}
