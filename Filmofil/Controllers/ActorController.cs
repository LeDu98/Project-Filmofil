using DataAccesLayer.UnitOfWork;
using Domen;
using Filmofil.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Controllers
{
    public class ActorController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ActorController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {

            List<Actor> model = unitOfWork.ActorRepository.GetAll().OfType<Actor>().ToList();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            Actor model = unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = id });
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Actor actor = (Actor)unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = id });

            ActorViewModel model = CreateModel(actor);

            return View(model);
        }

        private ActorViewModel CreateModel(Actor actor)
        {
            ActorViewModel model = new ActorViewModel();

            model.FirstName = actor.FirstName;
            model.LastName = actor.LastName;
            model.Born = actor.Born;
            model.CountryId = actor.CountryId;
            model.Networth = actor.Networth;

            return model;
        }



        // POST: StreamingServiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
    
}
