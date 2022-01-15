using DataAccesLayer.UnitOfWork;
using Domen;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Filmofil.Controllers
{
    public class MoviesController : Controller
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly IHostingEnvironment hostingEnvironment;
        private string folderPath = "img/MoviesImages";

        public MoviesController(IUnitOfWork unitOfWork, IHostingEnvironment hostingEnvironment)
        {
            this.unitOfWork = unitOfWork;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: MovieController
        public IActionResult Index()
        {
            List<Movie> model = unitOfWork.MovieRepository.GetAll().OfType<Movie>().ToList();

            return View(model);
        }

        // GET: MovieController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        public IActionResult Create(IFormCollection collection)
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

        // GET: MovieController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
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

        // GET: MovieController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
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
    }
}
