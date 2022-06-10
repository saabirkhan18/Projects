using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MVC2.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC2.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddUser()
        {
            return View(new Employee());
        }

        [HttpPost]
        public IActionResult AddUser(Employee employee)
        {
           
            if (ModelState.IsValid)
            {
                List<Employee> _ContactModelObjList = new List<Employee>();
                var Result = HttpContext.Session.GetString("_ContactModelObjList");
                if (Result == null)
                {
                    _ContactModelObjList.Add(employee);
                    HttpContext.Session.SetString("_ContactModelObjList", JsonConvert.SerializeObject(_ContactModelObjList));
                    return View(employee);
                }
                else
                {
                    _ContactModelObjList = JsonConvert.DeserializeObject<List<Employee>>(Result);
                    _ContactModelObjList.Add(employee);
                    HttpContext.Session.SetString("_ContactModelObjList", JsonConvert.SerializeObject(_ContactModelObjList));
                }
                return RedirectToAction("ViewUser");
            }
            ViewBag.ErrorMessage = "Please all fields";
            return View(employee);
        }
        public IActionResult ViewUser()
        {
            List<Employee> _ContactModelObjList = new List<Employee>();
            var Result = HttpContext.Session.GetString("_ContactModelObjList");
            if (Result != null)
            {
                _ContactModelObjList = JsonConvert.DeserializeObject<List<Employee>>(Result);
            }
            return View(_ContactModelObjList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
