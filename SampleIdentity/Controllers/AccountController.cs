using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using SampleIdentity.Models;


namespace SampleIdentity.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Login()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                if (loginModel.Username == "saabir" && loginModel.Password == "Password@123")
                {
                    var Identity = new ClaimsIdentity(
                        new[]
                        {
                            new Claim(ClaimTypes.Name, loginModel.Username),
                            new Claim(ClaimTypes.Email,"saabir@email.com")
                        },
                        CookieAuthenticationDefaults.AuthenticationScheme);                    
                    var Principal = new ClaimsPrincipal(Identity);
                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, Principal);
                    LoggedInuser.loginModels.Add(loginModel);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username and password!");
                }
            }
            else
            {
                ModelState.AddModelError("", "Oop's something went wrong!");
            }
            return View(loginModel);
        }
        public IActionResult Logout()
        {            
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View("Login");
        }
    }
}
