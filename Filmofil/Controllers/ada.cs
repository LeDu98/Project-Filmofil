using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Controllers
{
    public class ada : Controller
    {
        // GET: ada
        public ActionResult Index()
        {
            return View();
        }

        // GET: ada/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ada/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ada/Create
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

        // GET: ada/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ada/Edit/5
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

        // GET: ada/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ada/Delete/5
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
