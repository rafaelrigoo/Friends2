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
           
            var imagem5 = new Destaque();
            imagem5.CaminhoImagem = "/imagens/carrosel2.jpg";

            var imagem6 = new Destaque();
            imagem6.CaminhoImagem = "/imagens/carrosel3.jpg";

            var imagem2 = new Destaque();
            imagem2.CaminhoImagem = "/imagens/imagem-carrosell.jpg";

            var lista = new List<Destaque>() { imagem2, imagem6, imagem5,  imagem1};


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
