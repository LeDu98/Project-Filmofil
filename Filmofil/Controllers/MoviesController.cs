using DataAccesLayer.UnitOfWork;
using Domen;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public MoviesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Movie> model = unitOfWork.MovieRepository.GetAll().OfType<Movie>().ToList();
            return View(model);
        }
    }
}
