using DataAccesLayer.UnitOfWork;
using Domen;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Controllers
{
    public class ActorController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ActorController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {

            List<Actor> model = unitOfWork.ActorRepository.GetAll().OfType<Actor>().ToList();
            return View(model);
        }
    }
}
