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
            return View();
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
