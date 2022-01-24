using DataAccesLayer.UnitOfWork;
using Domen;
using Filmofil.Models;
using Filmofil.Models.Actor;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Filmofil.Views.Shared.SearchBar;
using Microsoft.AspNetCore.Authorization;

namespace Filmofil.Controllers
{   //[AllowAnonymus]

    public class ActorController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IHostingEnvironment hostingEnvironment;

        public ActorController(IUnitOfWork unitOfWork, IHostingEnvironment hostingEnvironment)
        {
            this.unitOfWork = unitOfWork;
            this.hostingEnvironment = hostingEnvironment;
        }


        public IActionResult Index(string SearchText = "")
        {
            ActorListViewModel model = new ActorListViewModel();
            List<Actor> lista;

            var user = HttpContext.User;

            model.IsAdmin = user.IsInRole("Admin");
            if (SearchText != "" && SearchText != null)
            {
                lista = unitOfWork.ActorRepository.GetAll().Where(a => String.Concat(a.FirstName, " ", a.LastName).ToLower().Contains(SearchText.ToLower()) || String.Concat(a.LastName, " ", a.FirstName).ToLower().Contains(SearchText.ToLower())).ToList();
            }
            else
            {
                lista = unitOfWork.ActorRepository.GetAll().OfType<Actor>().ToList();

            }
            model.Actors = lista;
            SPager SearchPager = new SPager() { Action = "Index", Controller = "Actor", SearchText = SearchText };
            ViewBag.SearchPager = SearchPager;
            return View(model);

        }
        [Authorize(Roles = "Admin")]
        
        public IActionResult Delete(int id)
        {
            Actor actor = (Actor)unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = id });

            ActorViewModel model = new ActorViewModel() { PersonId = actor.PersonId, FirstName = actor.FirstName, LastName = actor.LastName, Born = actor.Born, CountryId = actor.CountryId, Image = actor.Image, Networth = actor.Networth };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id, ActorViewModel model)
        {
            Actor actor = (Actor)unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = id });
            unitOfWork.ActorRepository.Delete(actor);
            unitOfWork.Save();

            return RedirectToAction("Actors","Dashboard");

        }


        public IActionResult Details(int id)
        {
            Actor a = unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = id });
            List<Acting> lista = new List<Acting>();
            lista = unitOfWork.ActingRepository.GetAll().Where(acting => acting.ActorId == a.PersonId).ToList();



            var user = HttpContext.User;

            ActorViewModel model = new ActorViewModel
            {
                Born = a.Born,
                CountryId = a.CountryId,
                FirstName = a.FirstName,
                Image = a.Image,
                LastName = a.LastName,
                Country = a.Country,
                Networth = a.Networth,
                PersonId = a.PersonId,
                Actings = lista,
                IsAdmin = user.IsInRole("Admin")
            };

            return View(model);
        }


        private CreateActorViewModel CreateModel(Actor actor)
        {
            CreateActorViewModel model = new CreateActorViewModel();

            model.FirstName = actor.FirstName;
            model.LastName = actor.LastName;
            model.Born = actor.Born;
            model.CountryId = actor.CountryId;
            model.ImageName = actor.Image;


            return model;
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            Actor actor = (Actor)unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = id });

            CreateActorViewModel model = CreateModel(actor);
            model.Countries = unitOfWork.CountryRepository.GetAll().OfType<Country>().ToList();

            return View(model);
        }

        // POST: Actor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id, CreateActorViewModel model)
        {
            Actor actor = (Actor)unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = id });
            if (!ModelState.IsValid)
            {
                return Edit(id);
            }



            string uniqueFileName = model.ImageName;

            if (model.Image != null)
            {
                uniqueFileName = GetFileNameAndSaveFile(model);
            }


            actor.FirstName = model.FirstName;
            actor.LastName = model.LastName;
            actor.Born = model.Born;
            actor.CountryId = model.CountryId;

            actor.Image = uniqueFileName;

            unitOfWork.ActorRepository.Update(actor);
            unitOfWork.Save();

            return RedirectToAction("Actors", "Dashboard");
        }
        [Authorize(Roles = "Admin")]
        
        public IActionResult Create()
        {
            CreateActorViewModel model = new CreateActorViewModel();
            model.Countries = unitOfWork.CountryRepository.GetAll().OfType<Country>().ToList();

            return View(model);
        }

        //POST: ActorController/Create
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(CreateActorViewModel model)
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



            unitOfWork.ActorRepository.Add(new Actor
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Born = model.Born,
                CountryId = model.CountryId,
                Image = uniqueFileName,

            });
            unitOfWork.Save();
            return RedirectToAction("Actors", "Dashboard");
        }

        private string GetFileNameAndSaveFile(CreateActorViewModel model)
        {
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img/ActorsImages");

            string uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            model.Image.CopyTo(new FileStream(filePath, FileMode.Create));

            return uniqueFileName;
        }
    }


}

