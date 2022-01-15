using DataAccesLayer.UnitOfWork;
using Domen;
using Filmofil.Models.Personnel;
using Filmofil.Views.Shared.SearchBar;
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

        public ActionResult Delete(int id)
        {
            Personnel personnel = (Personnel)unitOfWork.PersonnelRepository.GetSingle(new Personnel { PersonId = id });

            PersonnelViewModel model = new PersonnelViewModel() { PersonId = personnel.PersonId, FirstName = personnel.FirstName, LastName = personnel.LastName, Born = personnel.Born, CountryId = personnel.CountryId, Image = personnel.Image, Trademark = personnel.Trademark };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, PersonnelViewModel model)
        {
            Personnel personnel = (Personnel)unitOfWork.PersonnelRepository.GetSingle(new Personnel { PersonId = id });
            unitOfWork.PersonnelRepository.Delete(personnel);
            unitOfWork.Save();
            return RedirectToAction("Index");

        }

        public IActionResult Details(int id)
        {
            Personnel model = (Personnel)unitOfWork.PersonnelRepository.GetSingle(new Personnel { PersonId = id });
            model.Country = unitOfWork.CountryRepository.GetSingle(new Country { CountryId = model.CountryId });
            return View(model);
        }


        private CreatePersonnelViewModel CreateModel(Personnel personnel)
        {
            CreatePersonnelViewModel model = new CreatePersonnelViewModel();

            model.FirstName = personnel.FirstName;
            model.LastName = personnel.LastName;
            model.Born = personnel.Born;
            model.CountryId = personnel.CountryId;
            model.Trademark = personnel.Trademark;


            return model;
        }


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
        public IActionResult Edit(int id, CreatePersonnelViewModel model)
        {
            Personnel personnel = (Personnel)unitOfWork.PersonnelRepository.GetSingle(new Personnel { PersonId = id });
            if (!ModelState.IsValid)
            {
                return Edit(id);
            }

            string uniqueFileName = null;

            if (model.Image != null)
            {
                uniqueFileName = GetFileNameAndSaveFile(model);
            }


            personnel.FirstName = model.FirstName;
            personnel.LastName = model.LastName;
            personnel.Born = model.Born;
            personnel.CountryId = model.CountryId;
            personnel.Trademark = model.Trademark;
            personnel.Image = uniqueFileName;

            unitOfWork.PersonnelRepository.Update(personnel);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            CreatePersonnelViewModel model = new CreatePersonnelViewModel();
            model.Countries = unitOfWork.CountryRepository.GetAll().OfType<Country>().ToList();

            return View(model);
        }

        //POST: ActorController/Create
        [HttpPost]
        public IActionResult Create(CreatePersonnelViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Create();
            }

            string uniqueFileName = null;

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
            return RedirectToAction("Index");
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
    }
}
