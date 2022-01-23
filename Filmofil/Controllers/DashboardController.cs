using DataAccesLayer.UnitOfWork;
using Domen;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IHostingEnvironment hostingEnvironment;

        public DashboardController(IUnitOfWork unitOfWork, IHostingEnvironment hostingEnvironment)
        {
            this.unitOfWork = unitOfWork;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Actors()
        {
            List<Actor> model = unitOfWork.ActorRepository.GetAll().ToList();

            return View(model);

        }

        public IActionResult Personnels()
        {
            List<Personnel> model = unitOfWork.PersonnelRepository.GetAll().ToList();

            return View(model);

        }

        public IActionResult Movies()
        {
            List<Movie> model = unitOfWork.MovieRepository.GetAll().ToList();

            return View(model);

        }

        public IActionResult StreamingServices()
        {
            List<StreamingService> model = unitOfWork.StreamingServiceRepository.GetAll().ToList();

            return View(model);

        }

        public IActionResult Studios()
        {
            List<Studio> model = unitOfWork.StudioRepository.GetAll().ToList();

            return View(model);

        }
    }
}
