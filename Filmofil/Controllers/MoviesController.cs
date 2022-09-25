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
using Filmofil.Views.Shared.SearchBar;

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
        public IActionResult Index(string selectGenre, string SearchText = "")
        {
            List<Movie> movies = new List<Movie>();
            List<Genre> genres = unitOfWork.GenreRepository.GetAll().ToList();
            throw new Exception("OOPS! This movie cannot be deleted!");


            if ((selectGenre == null || selectGenre == "noFilter") && String.IsNullOrEmpty(SearchText))
            {
                movies = unitOfWork.MovieRepository.GetAll();
            }
            else
            {
                if ((selectGenre != null && selectGenre != "noFilter") && !String.IsNullOrEmpty(SearchText))
                {
                    movies = unitOfWork.MovieRepository.FindByNameAndGenre(SearchText, selectGenre);
                }
                else if (selectGenre != null && selectGenre != "noFilter")
                {
                    movies = unitOfWork.MovieRepository.FindByGenre(selectGenre);
                }
                else if (!String.IsNullOrEmpty(SearchText))
                {
                    movies = unitOfWork.MovieRepository.Find(SearchText);
                }
            }

            MovieIndexViewModel model = new MovieIndexViewModel { Movies = movies, Genres = genres, SearchText = SearchText };

            ViewData["SearchString"] = SearchText;
            ViewData["SelectedGenre"] = selectGenre;

            return View(model);

        }


        // GET: MovieController/Details/id
        public IActionResult Details(int id)
        {
            MovieViewModel model = CreateMovieViewModel(unitOfWork.MovieRepository.GetSingle(new Movie { MovieId = id }));
            List<Review> listOfReviews = new List<Review>();
            listOfReviews = unitOfWork.ReviewRepository.GetAll().Where(r => r.MovieId == model.MovieId).ToList();
            model.Review = new Review();
            model.Review.MovieId = id;
            model.Reviews = listOfReviews;

            model.Genres = unitOfWork.MovieGenreRepository.GetAll().Where(m => m.MovieId == id).ToList();
            
            if (User.Identity.IsAuthenticated)
            {
                var claimsIdentity = HttpContext.User.Identity as System.Security.Claims.ClaimsIdentity;
                int userId = Int32.Parse(claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value);
                model.IsRated = unitOfWork.ReviewRepository.IsRated(userId, id);
                model.UserId = userId;
            }
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

         

            List<MovieGenre> listOfMovieGenres = new List<MovieGenre>();
            
           
            foreach (int i in model.GenreIds)
            {
                MovieGenre mg = new MovieGenre();
                mg.GenreId = i;
                listOfMovieGenres.Add(mg);
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
                Year = model.Year,
                Actings=model.Actings,
                Positions=model.Positions,
                Genres=listOfMovieGenres
            });
            unitOfWork.Save();




            //if (model.Actings != null)
            //{
            //    AddActors(movieId, model.Actings);

            //}
            //if (model.Positions != null)
            //{
            //    AddPersonnel(movieId, model.Positions);

            //}
           
           // int movieId = unitOfWork.MovieRepository.GetMaxId();
          
            return RedirectToAction( "Movies", "Dashboard");

        }


        private string GetFileNameAndSaveFile(MovieCreateModel model)
        {
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, folderPath);

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
            var claimsIdentity = HttpContext.User.Identity as System.Security.Claims.ClaimsIdentity;
            int userId = Int32.Parse(claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value);

            //SiteUser siteUser = unitOfWork.SiteUserRepository.SearchByUsername(user.Identity.Name);
            //rev.User = siteUser;

            rev.UserId = userId;

            unitOfWork.ReviewRepository.Add(rev);
            unitOfWork.Save();
            return RedirectToAction(nameof(Details), new { id = rev.MovieId.ToString() });

        }


        // GET: MovieController/Edit/5
        public IActionResult Edit(int id)
        {

            Movie m = unitOfWork.MovieRepository.GetSingle(new Movie { MovieId = id });
            MovieCreateModel model = CreateModel(m);

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
            string thumb = null;

            if (model.Thumbnail != null)
            {
                uniqueFileName = GetFileNameAndSaveFile(model);
                thumb = uniqueFileName;
            }
            else
            {
                thumb = model.ThumbnailName;
            }
            Movie m = unitOfWork.MovieRepository.GetSingle(new Movie { MovieId = id });
            m.Duration = model.Duration;
            m.Name = model.Name;
            m.StreamingServiceId = model.StreamingServiceId;
            m.StudioId = model.StudioId;
            m.Synopsis = model.Synopsis;
            m.Thumbnail = thumb;
            m.Trailer = model.Trailer;
            m.Year = model.Year;


            MovieGenre mg = new MovieGenre();
            mg.MovieId = id;
            List<MovieGenre> listOfGenres = new List<MovieGenre>();

            foreach (int i in model.GenreIds)
            {
                mg.GenreId = i;
                listOfGenres.Add(mg);
            }

            m.Genres = listOfGenres;
            m.Actings = model.Actings;
            m.Positions = model.Positions;

            unitOfWork.MovieRepository.Update(m);
            unitOfWork.Save();

            

            //foreach(MovieGenre movieGenre in m.Genres)
            //{
            //    unitOfWork.MovieGenreRepository.Delete(movieGenre);
            //}

          

            //DeleteOldActors(id, m.Actings);

            //if (model.Actings != null)
            //{
            //    AddActors(id, model.Actings);
            //}

            //DeleteOldPersonnel(id, m.Positions);

            //if (model.Positions != null)
            //{
            //    AddPersonnel(id, model.Positions);
            //}

            return RedirectToAction("Details", "Movies", new { id = id });
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

            return RedirectToAction("Movies", "Dashboard");
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
                model.Actors.Add((Actor)unitOfWork.ActorRepository.GetSingle(new Actor { PersonId = a.ActorId }));
            }

            model.Personnel = new List<Personnel>();
            foreach (Position p in movie.Positions)
            {
                model.Personnel.Add((Personnel)unitOfWork.PersonnelRepository.GetSingle(new Personnel { PersonId = p.PersonnelId }));
            }

            return model;

        }


        private MovieCreateModel CreateModel(Movie m = null)
        {
            MovieCreateModel model = new MovieCreateModel();

            /*
             * Podaci o filmu i situaciji da se kreira model za Edit
             */
            if (m != null)
            {

                model.Duration = m.Duration;
                model.Name = m.Name;
                model.Synopsis = m.Synopsis;
                model.Trailer = m.Trailer;
                model.Year = m.Year;
                model.ThumbnailName = m.Thumbnail;
                model.StreamingServiceId = m.StreamingServiceId;
                model.StudioId = m.StudioId;

                model.Positions = m.Positions;
                model.Actings = m.Actings;

                model.MovieGenres = m.Genres;

                model.GenreIds = new int[m.Genres.Count()];
                for (int i = 0; i < m.Genres.Count(); i++)
                {

                    model.GenreIds[i] = m.Genres[i].GenreId;
                }

            }

            /*
             * Skupljanje podataka na osnovu kojih ce se selektovati vrednosti
             */
            model.StreamingServices = unitOfWork.StreamingServiceRepository.GetAll();
            model.Studios = unitOfWork.StudioRepository.GetAll();

            model.SelectListItemActors = CreateSelectListActors(unitOfWork.ActorRepository.GetAll());
            model.SelectListItemPersonnel = CreateSelectListPersonnel(unitOfWork.PersonnelRepository.GetAll());

            model.Genres = unitOfWork.GenreRepository.GetAll();
            return model;
        }


        private List<SelectListItemActors> CreateSelectListActors(List<Actor> actors)
        {
            List<SelectListItemActors> selectListItemActors = new List<SelectListItemActors>();

            foreach (Actor actor in actors)
            {
                selectListItemActors.Add(new SelectListItemActors
                {
                    IsSelected = false,
                    Actor = actor
                });
            }

            return selectListItemActors;
        }


        private List<SelectListItemPersonnel> CreateSelectListPersonnel(List<Personnel> personnels)
        {
            List<SelectListItemPersonnel> selectListItemPersonnel = new List<SelectListItemPersonnel>();

            foreach (Personnel personnel in personnels)
            {
                selectListItemPersonnel.Add(new SelectListItemPersonnel
                {
                    IsSelected = false,
                    Personnel = personnel
                });
            }

            return selectListItemPersonnel;
        }

        private bool DeleteOldActors(int movieId, List<Acting> actings)
        {
            foreach (Acting ac in actings)
            {
                unitOfWork.ActingRepository.Delete(ac);
            }

            unitOfWork.Save();

            return true;
        }

        private bool AddActors(int movieId, List<Acting> actings)
        {
            foreach (Acting acting in actings)
            {
                unitOfWork.ActingRepository.Add(new Acting { MovieId = movieId, ActorId = acting.ActorId, Income = acting.Income, Role = acting.Role });
            }

            unitOfWork.Save();

            return true;
        }

        private bool DeleteOldPersonnel(int movieId, List<Position> positions)
        {
            foreach (Position p in positions)
            {
                unitOfWork.PositionRepository.Delete(p);
            }

            unitOfWork.Save();

            return true;
        }

        public bool AddPersonnel(int movieId, List<Position> positions)
        {

            foreach (Position position in positions)
            {
                unitOfWork.PositionRepository.Add(new Position { MovieId = movieId, PersonnelId = position.PersonnelId, PositionTitle = position.PositionTitle });
            }

            unitOfWork.Save();

            return true;

        }


        private List<SelectListItem> GetGenresAsSelectList(List<Genre> genres)
        {
            List<SelectListItem> SelectList = new List<SelectListItem>();
            foreach (Genre g in genres)
            {
                SelectList.Add(new SelectListItem { Text = g.Name, Value = g.Name });
            }

            return SelectList;
        }


    }
}
