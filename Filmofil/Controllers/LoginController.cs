using DataAccesLayer.UnitOfWork;
using Filmofil.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUnitOfWork unitOfWork;

        public LoginController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel login)
        {

            if (!ModelState.IsValid)
            {
               return View();
            }

            var user = unitOfWork.UserRepository.SearchByUsernamePassword(login.Username, login.Password);
            if (user != null)
            {
                return RedirectToAction("Index", "Movies");
            }

            ModelState.AddModelError(string.Empty, "Wrong credentials!");

            return View();
        }
    }
}
