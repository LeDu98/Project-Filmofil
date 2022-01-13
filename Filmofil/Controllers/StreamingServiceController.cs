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
    public class StreamingServiceController : Controller
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly IHostingEnvironment hostingEnvironment;

        public StreamingServiceController(IUnitOfWork unitOfWork, IHostingEnvironment hostingEnvironment)
        {
            this.unitOfWork = unitOfWork;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: StreamingServiceController
        public IActionResult Index()
        {
            List<StreamingService> model = unitOfWork.StreamingServiceRepository.GetAll().OfType<StreamingService>().ToList();

            return View(model);
        }

        // GET: StreamingServiceController/Details/5
        public IActionResult Details(int id)
        {
            StreamingService model = unitOfWork.StreamingServiceRepository.GetSingle(new StreamingService { StreamingServiceId = id });
            return View(model);
        }

        // GET: StreamingServiceController/Create
        public IActionResult Create()
        {
            StreamingServiceCreateModel model = new StreamingServiceCreateModel();
            

            return View(model);
        }

        // POST: StreamingServiceController/Create
        [HttpPost]
        public IActionResult Create(StreamingServiceCreateModel model)
        {
            if (!ModelState.IsValid)
            {
                return Create();
            }

            string uniqueFileName = null;

            if (model.Img != null)
            {
                // The image must be uploaded to the images folder in wwwroot
                // To get the path of the wwwroot folder we are using the inject
                // HostingEnvironment service provided by ASP.NET Core
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img/streamingServiceLogo");
                // To make sure the file name is unique we are appending a new
                // GUID value and and an underscore to the file name
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Img.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                // Use CopyTo() method provided by IFormFile interface to
                // copy the file to wwwroot/images folder
                model.Img.CopyTo(new FileStream(filePath, FileMode.Create));
            }


           
            unitOfWork.StreamingServiceRepository.Add(new StreamingService
            {
                Name = model.Name,
                Founded = model.Founded,
                Headquarter = model.Headquarter,
                Price = model.Price,
                Website = model.Website,
                LogoImg = uniqueFileName
            });
            unitOfWork.Save();
            return RedirectToAction("Index");
        }

        // GET: StreamingServiceController/Edit/5
        public IActionResult Edit(int id)
        {
            StreamingService streamingService = (StreamingService) unitOfWork.StreamingServiceRepository.GetSingle(new StreamingService { StreamingServiceId = id });

            StreamingServiceViewModel model = CreateModel(streamingService);

            return View(model);
        }

        // POST: StreamingServiceController/Edit/5
        [HttpPost]
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

        // GET: StreamingServiceController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: StreamingServiceController/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, IFormCollection collection)
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


        private StreamingServiceViewModel CreateModel(StreamingService streamingService)
        {
            StreamingServiceViewModel model = new StreamingServiceViewModel();

            model.Name = streamingService.Name;
            model.Website = streamingService.Website;
            model.Headquarter = streamingService.Headquarter;
            model.Price = streamingService.Price;
            model.Founded = streamingService.Founded;

            return model;

        }


    }
}
