using Friends.Dados;
using Friends.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class ElencoController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public ElencoController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public IActionResult Index()
        {
            var elenco = applicationContext.Elenco;

            return View(elenco);
        }

      
        public IActionResult FichaCompleta(Elenco artista)
        {
            return View(artista);
        }
    }
}
