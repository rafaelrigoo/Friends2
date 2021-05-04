using Friends.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
       public IActionResult Login(string returnUrl)
        {
            var model = new LoginViewModel() { ReturnUrl = returnUrl };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if(model.Username == "rafa" && model.Password == "rafa")
                {
                    List<Claim> claims = new List<Claim>
                    {
                        new Claim("username", model.Username),
                        new Claim("email", "rafa@example.com.br")
                    };

                    ClaimsIdentity identity = new ClaimsIdentity(claims, "Cookies");

                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync(principal);

                    if(model.ReturnUrl == null || model.ReturnUrl == "")
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    return Redirect(model.ReturnUrl);
                }
            }

            return View(model);
        }
        public IActionResult NovoCadastro()
        {
            return View();
        }
    }
}
