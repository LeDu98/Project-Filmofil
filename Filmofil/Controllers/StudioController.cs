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
    public class StudioController : Controller
    {

        private readonly IUnitOfWork unitOfWork;

        public StudioController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: StudioController
        public ActionResult Index()
        {
            List<Studio> model = unitOfWork.StudioRepository.GetAll().OfType<Studio>().ToList();
            return View(model);
        }

        // GET: StudioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudioController/Create
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

        // GET: StudioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudioController/Edit/5
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

        // GET: StudioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudioController/Delete/5
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
