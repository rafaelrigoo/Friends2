using Friends.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class GerenciarCuriosidadeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var curio = new Elenco();
            curio.Personagem = "Rachel";
            var curioRachel = new Curiosidade();
            curioRachel.Descricao = "Fez o teste para ser a Monica";
            curio.Curiosidades.Add(curioRachel);


            var curio3 = new Elenco();
            curio3.Personagem = "Monica";
            var curioMonica = new Curiosidade();
            curioMonica.Descricao = "Fez o teste para ser a Rachel";
            curio3.Curiosidades.Add(curioMonica);

            var curio2 = new Curiosidade();
            curio2.Descricao = "Monica";

            curio.Curiosidades.Add(curio2);

            var listacuriosi = new List<Elenco>() { curio, curio3};

            return View(listacuriosi);
        }

       [HttpGet]
        public IActionResult Curiosidade()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Curiosidade(Curiosidade curiosidade)
        {
            if (ModelState.IsValid)
            {
                return Json(curiosidade);
            }

            return View(curiosidade);
        }
    }
    
}
