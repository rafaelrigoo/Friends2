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
        public IActionResult EditarElenco(int Id)
        {
            var artista = applicationContext.Elenco
                .FirstOrDefault(a => a.Id == Id);

            return View(artista);
        }

        [HttpPost]
        public IActionResult EditarElenco(Elenco elenco)
        {
           if(ModelState.IsValid)
            {
                if(elenco.Id != 0)
                  applicationContext.Elenco.Update(elenco); 
                
                else
                 applicationContext.Elenco.Add(elenco);
                


                applicationContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(elenco);
        }

       
        public IActionResult ExcluirElenco(int Id)
        {
            var artista = applicationContext.Elenco
                .FirstOrDefault(a => a.Id == Id);

            if(artista != null)
            {
                applicationContext.Remove(artista);
                applicationContext.SaveChanges();
            }

            TempData["Msg"] = "Artista removido com sucesso";

            return RedirectToAction("Index");
        }
    }
}
