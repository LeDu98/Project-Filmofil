using DataAccesLayer.UnitOfWork;
using Domen;
using Filmofil.Models.Movie;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
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
            MovieViewModel model = CreateMovieViewModel(unitOfWork.MovieRepository.GetSingle(new Movie { MovieId = id }));
            List<Review> listOfReviews = new List<Review>();
            listOfReviews = unitOfWork.ReviewRepository.GetAll().Where(r => r.MovieId == model.MovieId).ToList();
            model.Review = new Review();
            model.Review.MovieId = id;
            model.Reviews = listOfReviews;

            model.Genres = unitOfWork.MovieGenreRepository.GetAll().Where(m => m.MovieId == id).ToList();
            return View(model);
        }

        // GET: MovieController/Create
        public IActionResult Create()
        {
            MovieCreateModel model = CreateModel();

            return View(model);
        }

        // POST: MovieController/Create
        [HttpPost]
        public IActionResult Create(MovieCreateModel model)
        {
            if (!ModelState.IsValid)
            {
                return Create();
            }
            string uniqueFileName = null;

            if (model.Thumbnail != null)
            {
                uniqueFileName = GetFileNameAndSaveFile(model);
            }

            unitOfWork.MovieRepository.Add(new Movie
            {
                Duration = model.Duration,
                Name = model.Name,
                StreamingServiceId = model.StreamingServiceId,
                StudioId = model.StudioId,
                Synopsis = model.Synopsis,
                Thumbnail = uniqueFileName,
                Trailer = model.Trailer,
                Year = model.Year
            });
            unitOfWork.Save();

            int movieId = unitOfWork.MovieRepository.GetMaxId();
            MovieGenre mg = new MovieGenre();
            mg.MovieId = movieId;
         
            foreach(int i in model.GenreIds)
            { 
                mg.GenreId = i;
                unitOfWork.MovieGenreRepository.Add(mg);
                unitOfWork.Save();
            }
            
            return RedirectToAction("Index");
        }

        private string GetFileNameAndSaveFile(MovieCreateModel model)
        {
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img/MoviesImages");

            string uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Thumbnail.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            model.Thumbnail.CopyTo(new FileStream(filePath, FileMode.Create));

            return uniqueFileName;
        }

        [HttpPost]
        public IActionResult AddReview(MovieViewModel model)
        {
            Review rev = model.Review;
            rev.Time = System.DateTime.Now;
            var user = HttpContext.User;
            SiteUser siteUser = unitOfWork.SiteUserRepository.SearchByUsername(user.Identity.Name);

            rev.User = siteUser;
            rev.UserId = siteUser.Id;

            unitOfWork.ReviewRepository.Add(rev);

           int numberOfReviews= unitOfWork.ReviewRepository.GetAll().Where(r => r.MovieId == rev.MovieId).ToList().Count() + 1;
            int sumOfReviews = unitOfWork.ReviewRepository.GetSumOfReviews(rev) + rev.Rating;

            double rating = (double)sumOfReviews / numberOfReviews;

            Movie movie = unitOfWork.MovieRepository.GetSingle(new Movie { MovieId = rev.MovieId });
            movie.Rating = rating;
            unitOfWork.MovieRepository.Update(movie);
            unitOfWork.Save();
            return RedirectToAction(nameof(Details), new { id = rev.MovieId.ToString() });
            
        }

        public IActionResult AddActor(int id)
        {
            CreateMovieActorViewModel model = new CreateMovieActorViewModel();
            List<Acting> actings = new List<Acting>();
            Actor actor = new Actor();
            actings = unitOfWork.ActingRepository.GetAll().Where(m => m.MovieId == id).ToList();

            List<Actor> list = new List<Actor>();
            list = unitOfWork.ActorRepository.GetAll().ToList();

            foreach(Acting a in actings)
            {
                actor = unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = a.ActorId });
                list.Remove(actor);
            }
            model.Actors = list;
            
            return View(model);
        }

        [HttpPost]
        public IActionResult AddActor(int id,CreateMovieActorViewModel model)
        {
            
          unitOfWork.ActingRepository.Add(new Acting { MovieId = id, ActorId = model.ActorId,  Income = model.Income, Role = model.Role });
          unitOfWork.Save();
          return RedirectToAction("AddActor");
            
           
        }

        public IActionResult AddPersonnel(int id)
        {
            CreateMoviePersonnelViewModel model = new CreateMoviePersonnelViewModel();
            List<Position> positions = new List<Position>();
            Personnel personnel = new Personnel();
            positions = unitOfWork.PositionRepository.GetAll().Where(m => m.MovieId == id).ToList();

            List<Personnel> list = new List<Personnel>();
            list = unitOfWork.PersonnelRepository.GetAll().ToList();

            foreach (Position a in positions)
            {
                personnel = unitOfWork.PersonnelRepository.GetSingle(new Personnel { PersonId = a.PersonnelId });
                list.Remove(personnel);
            }
            model.Personnels = list;

            return View(model);
        }

        [HttpPost]
        public IActionResult AddPersonnel(int id, CreateMoviePersonnelViewModel model)
        {

            unitOfWork.PositionRepository.Add(new Position { MovieId = id, PersonnelId = model.PersonnelId, PositionTitle=model.PositionTitle });
            unitOfWork.Save();
            return RedirectToAction("AddPersonnel");


        }

        // GET: MovieController/Edit/5
        public IActionResult Edit(int id)
        {
            
            Movie m = unitOfWork.MovieRepository.GetSingle(new Movie { MovieId = id });
            MovieCreateModel model = CreateModel();
            model.Duration = m.Duration;
            model.Name = m.Name;
            model.Synopsis = m.Synopsis;
            model.Trailer = m.Trailer;
            model.Year = m.Year;
            

            return View(model);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, MovieCreateModel model)
        {

            if (!ModelState.IsValid)
            {
                return Edit(id);
            }
            string uniqueFileName = null;

            if (model.Thumbnail != null)
            {
                uniqueFileName = GetFileNameAndSaveFile(model);
            }

            Movie m = new Movie();
            m.MovieId = id;
            m.Thumbnail = uniqueFileName;
            m.Synopsis = model.Synopsis;
            m.StudioId = model.StudioId;
            m.StreamingServiceId = model.StreamingServiceId;
            m.Name = model.Name;
            m.Trailer = model.Trailer;
            m.Year = model.Year;
            m.Duration = model.Duration;


            unitOfWork.MovieRepository.Update(m);
            List<MovieGenre> listMG = unitOfWork.MovieGenreRepository.GetAll().Where(m => m.MovieId == id).ToList();
            foreach(MovieGenre movieGenre in listMG)
            {
                unitOfWork.MovieGenreRepository.Delete(movieGenre);
            }     
            
            MovieGenre mg = new MovieGenre();
            mg.MovieId = id;

            foreach (int i in model.GenreIds)
            {
                mg.GenreId = i;
                unitOfWork.MovieGenreRepository.Add(mg);
                unitOfWork.Save();
            }

            return RedirectToAction("Index");
        }

        // GET: MovieController/Delete/5
        public IActionResult Delete(int id)
        {
            Movie movie = unitOfWork.MovieRepository.GetSingle(new Movie { MovieId = id });
            MovieViewModel model = new MovieViewModel { MovieId = movie.MovieId, Duration = movie.Duration, Name = movie.Name, Rating = movie.Rating, Synopsis = movie.Synopsis, Thumbnail = movie.Thumbnail, Trailer = movie.Trailer, Year = movie.Year };
            return View(model);
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, MovieViewModel model)
        {
            Movie movie = (Movie)unitOfWork.MovieRepository.GetSingle(new Movie { MovieId = id });
            unitOfWork.MovieRepository.Delete(movie);
            unitOfWork.Save();

            return RedirectToAction("Index");
        }

        private MovieViewModel CreateMovieViewModel(Movie movie)
        {
            MovieViewModel model = new MovieViewModel();

            model.MovieId = movie.MovieId;
            model.Name = movie.Name;
            model.Duration = movie.Duration;
            model.Year = movie.Year;
            model.Synopsis = movie.Synopsis;
            model.Thumbnail = movie.Thumbnail;
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

        private MovieCreateModel CreateModel()
        {
            MovieCreateModel model = new MovieCreateModel();

            model.StreamingServices = unitOfWork.StreamingServiceRepository.GetAll();
            model.Studios = unitOfWork.StudioRepository.GetAll();
            model.Actors = unitOfWork.ActorRepository.GetAll();
            model.Personnels = unitOfWork.PersonnelRepository.GetAll();
            model.Genres = unitOfWork.GenreRepository.GetAll();
            return model;
        } 

    }
}
