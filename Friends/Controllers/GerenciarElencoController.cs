﻿using Friends.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class GerenciarElencoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var joey = new Elenco();
            joey.Personagem = "Joey";
            joey.NomeReal = "Matthew Steven LeBlanc";
            joey.DatadeNascimento = new DateTime(1967, 07, 25);
            joey.Nacionalidade = "Estados Unidos";
            joey.CaminhoImagem = "/imagens/joey.jpeg";

            var ross = new Elenco();
            ross.Personagem = "Ross";
            ross.NomeReal = "Ross";
            ross.CaminhoImagem = "/imagens/ross.jpg";

            var david = new Elenco();
            david.NomeReal = "David Crane";


            var joeylista = new List<Elenco>() { joey, ross, david };

            return View(joeylista);
        }

        [HttpGet]
        public IActionResult Elenco()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Elenco(Elenco elenco)
        {
            if (ModelState.IsValid)
            {
                return Json(elenco);
            }

            return View(elenco);
        }
    }
}
