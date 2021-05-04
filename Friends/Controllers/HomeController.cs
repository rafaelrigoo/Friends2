using Friends.Models;
using Friends.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            var imagem1 = new Destaque();
            imagem1.CaminhoImagem = "/imagens/friendsfundo.jpg";
            var imagem3 = new Destaque();
            imagem3.CaminhoImagem = "/imagens/imagem-carrosel.jpg";

            var imagem4 = new Destaque();
            imagem4.CaminhoImagem = "/imagens/imagem-carrosel4.jpg";

            var lista = new List<Destaque>() { imagem1, imagem3, imagem4 };


            return View(lista);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
