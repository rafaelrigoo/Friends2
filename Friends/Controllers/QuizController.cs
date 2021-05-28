using Friends.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class QuizController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
