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

namespace Filmofil.Controllers
{
    public class ActorController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IHostingEnvironment hostingEnvironment;

        public ActorController(IUnitOfWork unitOfWork, IHostingEnvironment hostingEnvironment)
        {
            this.unitOfWork = unitOfWork;
            this.hostingEnvironment = hostingEnvironment;
        }


        public IActionResult Index(string SearchText="")
        {
            List<Actor> model;

            if(SearchText != "" && SearchText != null)
            {
                model = unitOfWork.ActorRepository.GetAll().Where(a => String.Concat(a.FirstName," ",a.LastName).ToLower().Contains(SearchText.ToLower()) || String.Concat(a.LastName," ",a.FirstName).ToLower().Contains(SearchText.ToLower())).ToList();
            }
            else
            {
              model = unitOfWork.ActorRepository.GetAll().OfType<Actor>().ToList();

            }

            SPager SearchPager = new SPager() { Action = "Index", Controller = "Actor", SearchText = SearchText };
            ViewBag.SearchPager = SearchPager;
            return View(model);

        }

        public IActionResult Delete(int id)
        {
            Actor actor = (Actor)unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = id });

            ActorViewModel model = new ActorViewModel() { PersonId=actor.PersonId, FirstName = actor.FirstName, LastName = actor.LastName, Born = actor.Born,CountryId=actor.CountryId,Image=actor.Image,Networth=actor.Networth };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, ActorViewModel model)
        {
            Actor actor = (Actor)unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = id });
            unitOfWork.ActorRepository.Delete(actor);
            unitOfWork.Save();

            return RedirectToAction("Index");

        }

        public IActionResult Details(int id)
        {
            Actor model = unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = id });
            model.Country = unitOfWork.CountryRepository.GetSingle(new Country { CountryId = model.CountryId });
            return View(model);
        }


        private CreateActorViewModel CreateModel(Actor actor)
        {
            CreateActorViewModel model = new CreateActorViewModel();

            model.FirstName = actor.FirstName;
            model.LastName = actor.LastName;
            model.Born = actor.Born;
            model.CountryId = actor.CountryId;
            model.Networth = actor.Networth;
            

            return model;
        }


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
        public IActionResult Edit(int id, CreateActorViewModel model)
        {
            Actor actor = (Actor)unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = id });
            if (!ModelState.IsValid)
            {
                return Edit(id);
            }



            string uniqueFileName = null;

            if (model.Image != null)
            {
                uniqueFileName = GetFileNameAndSaveFile(model);   
            }


            actor.FirstName = model.FirstName;
            actor.LastName = model.LastName;
            actor.Born = model.Born;
            actor.CountryId = model.CountryId;
            actor.Networth = model.Networth;
            actor.Image = uniqueFileName;

            unitOfWork.ActorRepository.Update(actor);
            unitOfWork.Save();

            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            CreateActorViewModel model = new CreateActorViewModel();
            model.Countries= unitOfWork.CountryRepository.GetAll().OfType<Country>().ToList();

            return View(model);
        }

        //POST: ActorController/Create
          [HttpPost]
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
                  Networth = model.Networth
              });
              unitOfWork.Save();
              return RedirectToAction("Index");
          }

        private string GetFileNameAndSaveFile(CreateActorViewModel model)
        {
            // The image must be uploaded to the images folder in wwwroot
            // To get the path of the wwwroot folder we are using the inject
            // HostingEnvironment service provided by ASP.NET Core
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img/ActorsImages");
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

