using Microsoft.AspNetCore.Mvc;
using System;
using DataAccesLayer.UnitOfWork;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domen;

namespace Filmofil.Controllers
{
    public class ReviewController : Controller
    {

        private readonly IUnitOfWork unitOfWork;

        public ReviewController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        // [Authorize(Roles = "Admin")]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(int userId, int movieId)
        {
           
            unitOfWork.ReviewRepository.Delete(new Review { UserId = userId, MovieId = movieId });

            unitOfWork.Save();

            return RedirectToAction("Details", "Movies", new { id = movieId });

        }

    }
}
