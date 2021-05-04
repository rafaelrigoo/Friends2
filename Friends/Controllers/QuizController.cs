using Friends.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class QuizController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            var questao = new Quiz();

            questao.Pergunta = "Qual era o sobrenome do meio de Chandler Bing?";

            questao.Alternativas.Add(new Alternativa("Muriel", true));
            questao.Alternativas.Add(new Alternativa("Morgan", false));

            
            return View(questao);
        }
    }
}
