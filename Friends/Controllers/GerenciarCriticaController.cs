using Friends.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class GerenciarCriticaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var critica = new Critica();
            critica.Comentario = "aisuduiasndm";

            var critica2 = new Critica();
            critica2.Comentario = "11111";

            var listacritica = new List<Critica>() { critica, critica2 };

            return View(listacritica);
        }


        [HttpGet]
        public IActionResult Critica()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Critica(Critica critica)
        {
            return Json(critica);
        }
    }
}
