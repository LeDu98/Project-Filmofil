using Domen;
using Filmofil.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserManager<SiteUser> manager;
        private readonly SignInManager<SiteUser> signInManager;
        private readonly RoleManager<SiteUser> roleManager;
        public AuthenticationController(UserManager<SiteUser> manager, SignInManager<SiteUser> signInManager, RoleManager<SiteUser> roleManager)
        {
            this.manager = manager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        #region registration
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register([FromForm] RegisterViewModel register)
        {
            SiteUser user = new SiteUser
            {
                Email = register.Email,
                UserName = register.Username,
                FirstName = register.FirstName,
                LastName = register.LastName,
            };
           var result = await manager.CreateAsync(user, register.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }
            else
            {
                if (result.Errors.Any(e => e.Code == "DuplicateUserName"))
                {
                    ModelState.AddModelError("Username", result.Errors.FirstOrDefault(e => e.Code == "DuplicateUserName")?.Description);
                }
                if (result.Errors.Any(e => e.Code.Contains("Password")))
                {
                    ModelState.AddModelError("Password", result.Errors.FirstOrDefault(e => e.Code.Contains("Password"))?.Description);
                }

            return View();

            }

        }
        #endregion

        #region registration
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginViewModel login)
        {
            var result = await signInManager.PasswordSignInAsync(login.Username, login.Password, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        #endregion
    }
}
