using Domen;
using Filmofil.Models.Users;
using IdentityServer4;
using Microsoft.AspNetCore.Authentication;
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
        
       
        public AuthenticationController(UserManager<SiteUser> manager, SignInManager<SiteUser> signInManager)
        {
            this.manager = manager;
            this.signInManager = signInManager;
          
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
                IsAdministrator = false
            };
            try
            {
                if (register.Password != register.PasswordCheck)
                {
                    return View();
                }
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
            catch (Exception)
            {

                return View();
            }

            

        }
        #endregion

        #region Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginViewModel login)
        {
            if(login.Username=="" || login.Username == null)
            {
                return View();
            }
            var result = await signInManager.PasswordSignInAsync(login.Username, login.Password, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
