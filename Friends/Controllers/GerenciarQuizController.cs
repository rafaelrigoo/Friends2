using Friends.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class GerenciarQuizController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var perg = new Quiz();
            perg.Pergunta = "quem foi o primeiro?";

            var perg2 = new Quiz();
            perg2.Pergunta = "Quem viajou para?";

            var listaperguntas = new List<Quiz>() { perg, perg2 };

            return View(listaperguntas);
        }

        [HttpGet]
        public IActionResult Quiz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Quiz(Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                return Json(quiz);
            }

            return View(quiz);
        }
    }
}
