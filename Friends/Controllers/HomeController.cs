using Friends.Dados;
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
        private readonly ApplicationContext applicationContext;

        public HomeController(ILogger<HomeController> logger, ApplicationContext applicationContext)
        {
            _logger = logger;
            this.applicationContext = applicationContext;
        }

        public IActionResult Index()
        {
            
            var imagens = applicationContext.Destaques;


            return View(imagens);
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
