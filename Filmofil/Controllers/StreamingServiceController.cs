using DataAccesLayer.UnitOfWork;
using Domen;
using Filmofil.Models;
using Filmofil.Views.Shared.SearchBar;
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
        private string folderPath = "img/streamingServiceLogo";

        public StreamingServiceController(IUnitOfWork unitOfWork, IHostingEnvironment hostingEnvironment)
        {
            this.unitOfWork = unitOfWork;
            this.hostingEnvironment = hostingEnvironment;
        }


        // GET: StreamingServiceController
        public IActionResult Index(string SearchText = "")
        {
            List<StreamingService> model = new List<StreamingService>();

            var user = HttpContext.User;

            if (SearchText != "" && SearchText != null)
            {
                model = unitOfWork.StreamingServiceRepository.GetAll().Where(s => s.Name.ToLower().Contains(SearchText.ToLower())).ToList();
            }
            else
            {
                model = unitOfWork.StreamingServiceRepository.GetAll().OfType<StreamingService>().ToList();

            }

            SPager SearchPager = new SPager() { Action = "Index", Controller = "StreamingService", SearchText = SearchText };
            ViewBag.SearchPager = SearchPager;

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
                uniqueFileName = GetFileNameAndSaveFile(model);
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
            return RedirectToAction("StreamingServices", "Dashboard");
        }


        // GET: StreamingServiceController/Edit/5
        public IActionResult Edit(int id)
        {
            StreamingService ss = (StreamingService) unitOfWork.StreamingServiceRepository.GetSingle(new StreamingService { StreamingServiceId = id });

            StreamingServiceCreateModel model = new StreamingServiceCreateModel { Founded=ss.Founded,Headquarter=ss.Headquarter,ImageName=ss.LogoImg,Name=ss.Name,Price=ss.Price,Website=ss.Website};

            return View(model);
        }


        // POST: StreamingServiceController/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, StreamingServiceCreateModel model)
        {
            StreamingService streamingService = (StreamingService)unitOfWork.StreamingServiceRepository.GetSingle(new StreamingService { StreamingServiceId = id });

            if (!ModelState.IsValid)
            {
                return Edit(id);
            }

            string uniqueFileName = null;

            if (model.Img != null)
            {
                uniqueFileName = GetFileNameAndSaveFile(model);
                streamingService.LogoImg = uniqueFileName;
            }
            else
            {
                streamingService.LogoImg = model.ImageName;

            }

            streamingService.Name = model.Name;
            streamingService.Founded = model.Founded;
            streamingService.Price = model.Price;
            streamingService.Website = model.Website;
            streamingService.Headquarter = model.Headquarter;

            unitOfWork.StreamingServiceRepository.Update(streamingService);
            unitOfWork.Save();

            return RedirectToAction("StreamingServices","Dashboard");
        }


        // GET: StreamingServiceController/Delete/5
        public IActionResult Delete(int id)
        {
            StreamingService streamingService = (StreamingService)unitOfWork.StreamingServiceRepository.GetSingle(new StreamingService { StreamingServiceId = id });

            StreamingServiceViewModel model = CreateModel(streamingService);

            return View(model);
        }


        // POST: StreamingServiceController/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, StreamingServiceViewModel model)
        {
            StreamingService streamingService = (StreamingService)unitOfWork.StreamingServiceRepository.GetSingle(new StreamingService { StreamingServiceId = id });

            if (DeleteFile(streamingService.LogoImg))
            {
                Console.WriteLine("File Deleted");
            }
            else
            {
                Console.WriteLine("Error trying to delte file");
            }

            unitOfWork.StreamingServiceRepository.Delete(streamingService);
            unitOfWork.Save();

            return RedirectToAction("StreamingServices", "Dashboard");
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


        private string GetFileNameAndSaveFile(StreamingServiceCreateModel model)
        {
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, folderPath);

            string uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Img.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            model.Img.CopyTo(new FileStream(filePath, FileMode.Create));

            return uniqueFileName;
        }

        private bool DeleteFile(string fileName)
        {
            try
            {
                string path = Path.Combine(hostingEnvironment.WebRootPath, folderPath);
                path = Path.Combine(path, fileName);

                FileInfo file = new FileInfo(path);
                if (file.Exists)
                {
                    file.Delete();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

    }
}
