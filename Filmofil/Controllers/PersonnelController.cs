using DataAccesLayer.UnitOfWork;
using Domen;
using Filmofil.Models.Personnel;
using Filmofil.Views.Shared.SearchBar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Controllers
{
    public class PersonnelController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IHostingEnvironment hostingEnvironment;
        private string imgName;

        public PersonnelController(IUnitOfWork unitOfWork, IHostingEnvironment hostingEnvironment)
        {
            this.unitOfWork = unitOfWork;
            this.hostingEnvironment = hostingEnvironment;
        }


        public IActionResult Index(string SearchText)
        {
            List<Personnel> model;

            if (SearchText != "" && SearchText != null)
            {
                model = unitOfWork.PersonnelRepository.GetAll().Where(p => String.Concat(p.FirstName, " ", p.LastName).ToLower().Contains(SearchText.ToLower()) || String.Concat(p.LastName, " ", p.FirstName).ToLower().Contains(SearchText.ToLower())).ToList();
            }
            else
            {
                model = unitOfWork.PersonnelRepository.GetAll().OfType<Personnel>().ToList();

            }

            SPager SearchPager = new SPager() { Action = "Index", Controller = "Personnel", SearchText = SearchText };
            ViewBag.SearchPager = SearchPager;
            return View(model);
        }
       
        // [Authorize(Roles ="Admin")]
        public ActionResult Delete(int id)
        {
            Personnel personnel = (Personnel)unitOfWork.PersonnelRepository.GetSingle(new Personnel { PersonId = id });

            PersonnelViewModel model = new PersonnelViewModel() { PersonId = personnel.PersonId, FirstName = personnel.FirstName, LastName = personnel.LastName, Born = personnel.Born, CountryId = personnel.CountryId, Image = personnel.Image, Trademark = personnel.Trademark };
            
            return View(model);
        }
      
        // [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, PersonnelViewModel model)
        {
            Personnel personnel = new Personnel { PersonId = id };

            unitOfWork.PersonnelRepository.Delete(personnel);

            unitOfWork.Save();

            return RedirectToAction("Personnels", "Dashboard");

        }

        public IActionResult Details(int id)
        {
            var user = HttpContext.User;

            Personnel personnel = (Personnel)unitOfWork.PersonnelRepository.GetSingle(new Personnel { PersonId = id });

            List<Position> listOfPositions = new List<Position>();

            listOfPositions = unitOfWork.PositionRepository.GetAll().Where(pos => pos.PersonnelId == personnel.PersonId).ToList(); 

            PersonnelViewModel model = new PersonnelViewModel
            {
                FirstName = personnel.FirstName,
                LastName = personnel.LastName,
                Born = personnel.Born,
                CountryId = personnel.CountryId,
                Trademark = personnel.Trademark,
                Country = personnel.Country,
                Image = personnel.Image,
                PersonId = personnel.PersonId,
                Positions=listOfPositions,
                IsAdmin = user.IsInRole("Admin")
            };
            return View(model);
        }

        //  [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            Personnel personnel = (Personnel)unitOfWork.PersonnelRepository.GetSingle(new Personnel { PersonId = id });

            CreatePersonnelViewModel model = CreateModel(personnel);
            model.Countries = unitOfWork.CountryRepository.GetAll().OfType<Country>().ToList();
            
            return View(model);
        }

        // POST: Actor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "Admin")]
        public IActionResult Edit(int id, CreatePersonnelViewModel model)
        {
            string uniqueFileName = null;

            Personnel personnel = new Personnel();

            if (!ModelState.IsValid)
            {
                return Edit(id);
            }

            

            if (model.Image != null)
            {
                uniqueFileName = GetFileNameAndSaveFile(model);
                personnel.Image = uniqueFileName;

            }
            else
            {
                personnel.Image = model.ImageName;
            }

            personnel.PersonId = id;
            personnel.FirstName = model.FirstName;
            personnel.LastName = model.LastName;
            personnel.Born = model.Born;
            personnel.CountryId = model.CountryId;
            personnel.Trademark = model.Trademark;

            unitOfWork.PersonnelRepository.Update(personnel);
            unitOfWork.Save();
            return RedirectToAction("Personnels", "Dashboard");
        }
       
        // [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            CreatePersonnelViewModel model = new CreatePersonnelViewModel();
            model.Countries = unitOfWork.CountryRepository.GetAll().OfType<Country>().ToList();

            return View(model);
        }

        //POST: ActorController/Create
       // [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(CreatePersonnelViewModel model)
        {
            string uniqueFileName = null;

            if (!ModelState.IsValid)
            {
                return Create();
            }
                
            if (model.Image != null)
            {
                uniqueFileName = GetFileNameAndSaveFile(model);
            }

            unitOfWork.PersonnelRepository.Add(new Personnel
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Born = model.Born,
                CountryId = model.CountryId,
                Image = uniqueFileName,
                Trademark = model.Trademark
            });
            unitOfWork.Save();
            return RedirectToAction("Personnels", "Dashboard");
        }

        private string GetFileNameAndSaveFile(CreatePersonnelViewModel model)
        {
            // The image must be uploaded to the images folder in wwwroot
            // To get the path of the wwwroot folder we are using the inject
            // HostingEnvironment service provided by ASP.NET Core
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img/PersonnelImages");
            // To make sure the file name is unique we are appending a new
            // GUID value and and an underscore to the file name
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            // Use CopyTo() method provided by IFormFile interface to
            // copy the file to wwwroot/images folder
            model.Image.CopyTo(new FileStream(filePath, FileMode.Create));

            return uniqueFileName;
        }

        private CreatePersonnelViewModel CreateModel(Personnel personnel)
        {
            CreatePersonnelViewModel model = new CreatePersonnelViewModel();

            model.FirstName = personnel.FirstName;
            model.LastName = personnel.LastName;
            model.Born = personnel.Born;
            model.CountryId = personnel.CountryId;
            model.Trademark = personnel.Trademark;
            model.ImageName = personnel.Image;


            return model;
        }
    }
}
