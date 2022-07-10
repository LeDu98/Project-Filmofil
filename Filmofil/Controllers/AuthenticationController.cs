using DataAccesLayer.UnitOfWork;
using Domen;
using Filmofil.Models.Users;
using Filmofil.Views.Shared.SearchBar;
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
        private readonly IUnitOfWork unitOfWork;
        
       
        public AuthenticationController(UserManager<SiteUser> manager, SignInManager<SiteUser> signInManager, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
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
                var addRole= await manager.AddToRoleAsync(user, "User");
                
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
            if(login.Password==null || login.Username == null)
            {
                return View();
            }
            Task<bool> result = unitOfWork.SiteUserRepository.LoginAsync(signInManager, login.Username, login.Password);
                

            if (result.Result)
            {
                return RedirectToAction("Index", "Home");
            }

            LoginViewModel model = new LoginViewModel { Message = "Wrong username or password!" };
            return View(model);
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        
        public IActionResult Users(string SearchText)
        {

            UserListModel model = new UserListModel();
            List<SiteUser> listOfUsers;

            var user = HttpContext.User;

            if (SearchText == null || SearchText == "")
            {
                model.Users = unitOfWork.SiteUserRepository.GetAll();
            }
            else
            {
                listOfUsers = unitOfWork.SiteUserRepository.FindByString(SearchText);
                model.Users = listOfUsers;
                
            }
           


            SPager SearchPager = new SPager() { Action = "Users", Controller = "Authentication", SearchText = SearchText };
            ViewBag.SearchPager = SearchPager;

         
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var user = manager.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return RedirectToAction("Users");
            }
            SiteUserViewModel model = new SiteUserViewModel { UserId = id, Email = user.Email, FirstName = user.FirstName, LastName = user.LastName, Username = user.UserName };

            
            return View(model);
        }
        // [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, SiteUserViewModel model)
        {
            var user =  manager.Users.FirstOrDefault(u => u.Id == id);
            await manager.DeleteAsync(user);
            
            return RedirectToAction("Users");

        }

        public IActionResult Promote(int id)
        {
            var user = manager.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return RedirectToAction("Users");
            }
            SiteUserViewModel model = new SiteUserViewModel { UserId = id, Email = user.Email, FirstName = user.FirstName, LastName = user.LastName, Username = user.UserName };


            return View(model);
        }
        // [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Promote(int id, SiteUserViewModel model)
        {
            var user = manager.Users.FirstOrDefault(u => u.Id == id);
            await manager.AddToRoleAsync(user, "Admin");
            user.IsAdministrator = true;
            await manager.UpdateAsync(user);



            return RedirectToAction("Users");

        }
    }
}
