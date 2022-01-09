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
    public class StreamingServiceController : Controller
    {

        private readonly IUnitOfWork unitOfWork;

        public StreamingServiceController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: StreamingServiceController
        public ActionResult Index()
        {
            List<StreamingService> model = unitOfWork.StreamingServiceRepository.GetAll().OfType<StreamingService>().ToList();

            return View(model);
        }

        // GET: StreamingServiceController/Details/5
        public ActionResult Details(int id)
        {
            StreamingService model = unitOfWork.StreamingServiceRepository.GetSingle(new StreamingService { StreamingServiceId = id });
            return View(model);
        }

        // GET: StreamingServiceController/Create
        public ActionResult Create()
        {
            StreamingServiceViewModel model = new StreamingServiceViewModel();

            return View(model);
        }

        // POST: StreamingServiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            if (!ModelState.IsValid)
            {
                return Create();
            }
            /*
            var pass = $"{student.FirstName[0]}{student.LastName[0]}{student.EnrollmentYear}{student.EnrollmentNumber}";

            unitOfWork.StudentRepository.Add(new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                EnrollmentYear = student.EnrollmentYear,
                Username = student.UserName,
                EnrollmentNumber = student.EnrollmentNumber,
                SpId = student.StudyProgramId,
                Password = pass
            });
            unitOfWork.Save();*/
            return RedirectToAction("Index");
        }

        // GET: StreamingServiceController/Edit/5
        public ActionResult Edit(int id)
        {
            StreamingService streamingService = (StreamingService) unitOfWork.StreamingServiceRepository.GetSingle(new StreamingService { StreamingServiceId = id });

            StreamingServiceViewModel model = CreateModel(streamingService);

            return View(model);
        }

        // POST: StreamingServiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StreamingServiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
