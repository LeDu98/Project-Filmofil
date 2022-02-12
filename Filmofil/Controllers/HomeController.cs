using DataAccesLayer.UnitOfWork;
using Domen;
using Filmofil.Models.Home;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;



namespace Filmofil.Controllers
{
    [System.Web.Mvc.HandleError]
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
            List<Movie> newReleasesMovies = unitOfWork.MovieRepository.GetAll().OrderByDescending(m => m.Year).Take(10).ToList();

            List<Movie> topRatedMovies = unitOfWork.MovieRepository.GetAll().OrderByDescending(m => m.Rating).Take(10).ToList();

            List<MovieGenre> actionMovies = unitOfWork.MovieGenreRepository.GetAll().OrderByDescending(mg => mg.Movie.Rating).Where(g => g.Genre.Name == "Action").Take(10).ToList();

            List<MovieGenre> comedyMovies= unitOfWork.MovieGenreRepository.GetAll().OrderByDescending(mg => mg.Movie.Rating).Where(g => g.Genre.Name == "Comedy").Take(10).ToList();
            List<MovieGenre> dramaMovies = unitOfWork.MovieGenreRepository.GetAll().OrderByDescending(mg => mg.Movie.Rating).Where(g => g.Genre.Name == "Drama").Take(10).ToList();

            List<MovieGenre> fantasyMovies = unitOfWork.MovieGenreRepository.GetAll().OrderByDescending(mg => mg.Movie.Rating).Where(g => g.Genre.Name == "Fantasy").Take(10).ToList(); 
            List<MovieGenre> horrorMovies = unitOfWork.MovieGenreRepository.GetAll().OrderByDescending(mg => mg.Movie.Rating).Where(g => g.Genre.Name == "Horror").Take(10).ToList();

            List<MovieGenre> mysteryMovies = unitOfWork.MovieGenreRepository.GetAll().OrderByDescending(mg => mg.Movie.Rating).Where(g => g.Genre.Name == "Mystery").Take(10).ToList();
            List<MovieGenre> romanceMovies = unitOfWork.MovieGenreRepository.GetAll().OrderByDescending(mg => mg.Movie.Rating).Where(g => g.Genre.Name == "Romance").Take(10).ToList();

            List<MovieGenre> thrillerMovies = unitOfWork.MovieGenreRepository.GetAll().OrderByDescending(mg => mg.Movie.Rating).Where(g => g.Genre.Name == "Thriller").Take(10).ToList();
            List<MovieGenre> westernMovies = unitOfWork.MovieGenreRepository.GetAll().OrderByDescending(mg => mg.Movie.Rating).Where(g => g.Genre.Name == "Western").Take(10).ToList();

            List<MovieGenre> crimeMovies = unitOfWork.MovieGenreRepository.GetAll().OrderByDescending(mg => mg.Movie.Rating).Where(g => g.Genre.Name == "Crime").Take(10).ToList();
            List<MovieGenre> adventureMovies = unitOfWork.MovieGenreRepository.GetAll().OrderByDescending(mg => mg.Movie.Rating).Where(g => g.Genre.Name == "Adventure").Take(10).ToList();

            List<MovieGenre> sciFiMovies = unitOfWork.MovieGenreRepository.GetAll().OrderByDescending(mg => mg.Movie.Rating).Where(g => g.Genre.Name == "Sci-Fi").Take(10).ToList();
            List<MovieGenre> biographyMovies = unitOfWork.MovieGenreRepository.GetAll().OrderByDescending(mg => mg.Movie.Rating).Where(g => g.Genre.Name == "Biography").Take(10).ToList();


            HomeViewModel model = new HomeViewModel
            {
                Action = actionMovies,
                Adventure = adventureMovies,
                Comedy = comedyMovies,
                Crime = crimeMovies,
                Drama = dramaMovies,
                Fantasy = fantasyMovies,
                Horror = horrorMovies,
                Mystery = mysteryMovies,
                NewReleases = newReleasesMovies,
                Romance = romanceMovies,
                Thriller = thrillerMovies,
                TopRated = topRatedMovies,
                Western = westernMovies,
                SciFi=sciFiMovies,
                Biography=biographyMovies
            };
            
            return View(model);
        }

        
    }
}
