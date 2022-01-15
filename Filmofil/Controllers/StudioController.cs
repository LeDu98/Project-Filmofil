using DataAccesLayer.UnitOfWork;
using Domen;
using Filmofil.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Controllers
{
    public class StudioController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IHostingEnvironment hostingEnvironment;
        public StudioController(IUnitOfWork unitOfWork, IHostingEnvironment hostingEnvironment)
        {
            this.unitOfWork = unitOfWork;
            this.hostingEnvironment = hostingEnvironment;

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
        public IActionResult Create(CreateStudioViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Create();
            }
            string uniqueFileName = null;

            if (model.LogoImg != null)
            {
                uniqueFileName = GetFileNameAndSaveFile(model);
            }

            unitOfWork.StudioRepository.Add(new Studio
            { Name = model.Name, Headquarter = model.Headquarter, Founded = model.Founded,LogoImg=uniqueFileName,Website=model.Website });
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

            CreateStudioViewModel model = new CreateStudioViewModel() {Founded=studio.Founded,Website=studio.Website,Headquarter=studio.Headquarter,Name=studio.Name };

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
        public IActionResult Edit(int id, CreateStudioViewModel model)
        {
            Studio studio = (Studio)unitOfWork.StudioRepository.GetSingle(new Studio { StudioId = id });
            if (!ModelState.IsValid)
            {
                return Edit(id);
            }



            string uniqueFileName = null;

            if (model.LogoImg != null)
            {
                uniqueFileName = GetFileNameAndSaveFile(model);
            }


            studio.Name = model.Name;
            studio.Headquarter = model.Headquarter;
            studio.Founded = model.Founded;
            studio.Website = model.Website;
            studio.LogoImg = uniqueFileName;
           

            unitOfWork.StudioRepository.Update(studio);
            unitOfWork.Save();

            return RedirectToAction("Index");
        }

        private string GetFileNameAndSaveFile(CreateStudioViewModel model)
        {
            // The image must be uploaded to the images folder in wwwroot
            // To get the path of the wwwroot folder we are using the inject
            // HostingEnvironment service provided by ASP.NET Core
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img/studioLogo");
            // To make sure the file name is unique we are appending a new
            // GUID value and and an underscore to the file name
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + model.LogoImg.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            // Use CopyTo() method provided by IFormFile interface to
            // copy the file to wwwroot/images folder
            model.LogoImg.CopyTo(new FileStream(filePath, FileMode.Create));

            return uniqueFileName;
        }

        public IActionResult Delete(int id)
        {
            Studio studio = (Studio)unitOfWork.StudioRepository.GetSingle(new Studio { StudioId = id });

            StudioViewModel model = new StudioViewModel() { StudioId=studio.StudioId,Founded=studio.Founded,Headquarter=studio.Headquarter,LogoImg=studio.LogoImg,Name=studio.Name,Website=studio.Website };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, StudioViewModel model)
        {
            Studio studio = (Studio)unitOfWork.StudioRepository.GetSingle(new Studio { StudioId = id });
            unitOfWork.StudioRepository.Delete(studio);
            unitOfWork.Save();

            return RedirectToAction("Index");

        }
    }
}
