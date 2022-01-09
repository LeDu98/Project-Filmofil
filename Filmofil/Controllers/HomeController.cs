using Domen;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Filmofil.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var user = JsonSerializer.Deserialize<User>(HttpContext.Session.Get("user"));
            if (user is null) {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
