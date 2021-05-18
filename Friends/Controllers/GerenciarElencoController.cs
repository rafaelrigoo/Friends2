using Friends.Dados;
using Friends.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class GerenciarElencoController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public GerenciarElencoController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var elenco = applicationContext.Elenco;
            return View(elenco);
        }

        [HttpGet]
        public IActionResult EditarElenco(string personagem)
        {
            var artista = applicationContext.Elenco
                .FirstOrDefault(a => a.Personagem == personagem);

            return View(artista);
        }

        [HttpPost]
        public IActionResult EditarElenco(Elenco elenco)
        {
            if (ModelState.IsValid)
            {
                applicationContext.Elenco.Add(elenco);
                applicationContext.SaveChanges();
            }

            return View();
        }

        public IActionResult ExcluirElenco(Elenco elenco)
        {
            var artista = applicationContext.Elenco
                .FirstOrDefault(a => a.Personagem == elenco.Personagem);

            if(artista != null)
            {
                applicationContext.Remove(artista);
                applicationContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
