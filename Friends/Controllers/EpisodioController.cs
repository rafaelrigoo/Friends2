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
           
            return View();
        }

        public IActionResult AdicionarEpisodios(Episodio episodio)
        {
            return View();
        }
    }
}
