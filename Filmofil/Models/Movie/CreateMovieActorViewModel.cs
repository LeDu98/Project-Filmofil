using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Models.Movie
{
    public class CreateMovieActorViewModel
    {
        public int ActorId { get; set; }
        public int MovieId { get; set; }

        public List<Domen.Actor> Actors { get; set; }
        public string Role { get; set; }

        public double Income { get; set; }


    }
}
