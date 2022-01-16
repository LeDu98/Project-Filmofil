using DataAccesLayer.UnitOfWork;
using Domen;
using Filmofil.Models.Movie;
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
            MovieViewModel model = CreateModel(unitOfWork.MovieRepository.GetSingle(new Movie { MovieId = id }));
            return View(model);
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

        private MovieViewModel CreateModel(Movie movie)
        {
            MovieViewModel model = new MovieViewModel();

            model.MovieId = movie.MovieId;
            model.Name = movie.Name;
            model.Duration = movie.Duration;
            model.Year = movie.Year;
            model.Synopsis = movie.Synopsis;
            model.Thumbnail = movie.Thumbnail;
            model.Genres = movie.Genres;
            model.Rating = movie.Rating;
            model.Trailer = movie.Trailer;
            model.StreamingService = movie.StreamingService;
            model.Studio = movie.Studio;
            model.Actings = movie.Actings;
            model.Positions = movie.Positions;

            model.Actors = new List<Actor>();
            foreach (Acting a in movie.Actings)
            {
                model.Actors.Add((Actor) unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = a.ActorId }));
            }

            model.Personnels = new List<Personnel>();
            foreach (Position p in movie.Positions)
            {
                model.Personnels.Add((Personnel)unitOfWork.PersonnelRepository.GetSingle(new Personnel { PersonId = p.PersonnelId }));
            }

            return model;

        }

    }
}
