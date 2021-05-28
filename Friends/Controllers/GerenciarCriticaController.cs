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
            return View();
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
