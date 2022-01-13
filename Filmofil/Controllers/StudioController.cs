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
    public class StudioController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public StudioController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            List<Studio> model = unitOfWork.StudioRepository.GetAll().OfType<Studio>().ToList();
            return View(model);
        }
        public IActionResult Create()
        {
            CreateStudioViewModel model = new CreateStudioViewModel();

            return View(model);
        }
        [HttpPost]
        public IActionResult Create(CreateStudioViewModel studio)
        {
            if (!ModelState.IsValid)
            {
                return Create();
            }
            unitOfWork.StudioRepository.Add(new Studio
            { Name = studio.Name, Headquarter = studio.Headquarter, Founded = studio.Founded });
            unitOfWork.Save();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Studio model = unitOfWork.StudioRepository.GetSingle(new Studio { StudioId = id });
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Studio studio = (Studio)unitOfWork.StudioRepository.GetSingle(new Studio { StudioId = id });

            StudioViewModel model = CreateModel(studio);

            return View(model);
        }

        private StudioViewModel CreateModel(Studio studio)
        {
            StudioViewModel model = new StudioViewModel();

            model.Name = studio.Name;
            model.Website = studio.Website;
            model.Headquarter = studio.Headquarter;       
            model.Founded = studio.Founded;

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
