using DataAccesLayer.UnitOfWork;
using Domen;
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
            List<StreamingService> model = unitOfWork.StudioRepository.GetAll().OfType<StreamingService>().ToList();
            return View(model);
        }

        // GET: StreamingServiceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StreamingServiceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StreamingServiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: StreamingServiceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
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
    }
}
