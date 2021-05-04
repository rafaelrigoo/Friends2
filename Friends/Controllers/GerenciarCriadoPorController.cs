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
        [HttpGet]
        public IActionResult Index()
        {
            var joey = new CriadoPor();
            joey.NomeReal = "MartA";
            joey.DatadeNascimento = new DateTime(1967, 07, 25);
            joey.Nacionalidade = "Estados Unidos";
            joey.CaminhoImagem = "/imagens/joey.jpeg";

            var ross = new CriadoPor();
            ross.NomeReal = "Roteirista";
            ross.CaminhoImagem = "/imagens/ross.jpg";

            var david = new CriadoPor();
            david.NomeReal = "David Crane";


            var joeylista = new List<CriadoPor>() { joey, ross, david };

            return View(joeylista);
        }

        [HttpGet]
        public IActionResult CriadoPor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CriadoPor(CriadoPor criador)
        {
            if (ModelState.IsValid)
            {
                return Json(criador);
            }

            return View(criador);
        }
    }
}
