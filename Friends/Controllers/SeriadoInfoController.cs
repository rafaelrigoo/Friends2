using Friends.Dados;
using Friends.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class SeriadoInfoController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public SeriadoInfoController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }
        public IActionResult Index()
        {
            var seriadoInfo = applicationContext.Informacoes;
            return View(seriadoInfo);
        }
    }
}
