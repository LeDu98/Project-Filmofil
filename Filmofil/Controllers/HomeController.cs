using DataAccesLayer.UnitOfWork;
using Domen;
using Filmofil.Models.Home;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Filmofil.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: MovieController
        public IActionResult Index()
        {
            List<Movie> movies = unitOfWork.MovieRepository.GetAll().OfType<Movie>().ToList();

            List<MovieGenre> movieGenres = unitOfWork.MovieGenreRepository.GetAll().OfType<MovieGenre>().ToList();
            HomeViewModel model = new HomeViewModel();
            model.ListOfMovieGenres = movieGenres;
            model.ListOfMovies = movies;
            return View(model);
        }
    }
}
