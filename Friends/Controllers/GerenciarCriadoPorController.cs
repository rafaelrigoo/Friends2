using Friends.Dados;
using Friends.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class GerenciarCriadoPorController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public GerenciarCriadoPorController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var criadores = applicationContext.Criadores;

            return View(criadores);
        }

        [HttpGet]
        public IActionResult EditarCriadoPor(int Id)
        {
            var criadores = applicationContext.Criadores
                .FirstOrDefault(c => c.Id == Id);

            return View(criadores);
        }

        [HttpPost]
        public IActionResult CriadoPor(CriadoPor criador)
        {
            return View();
        }
    }
}
