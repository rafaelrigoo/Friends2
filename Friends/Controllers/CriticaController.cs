using Friends.Dados;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class CriticaController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public CriticaController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public IActionResult Index()
        {
            
            return View();
        }
    }
}
