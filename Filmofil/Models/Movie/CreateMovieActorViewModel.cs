using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Models.Movie
{
    public class CreateMovieActorViewModel
    {
        public int ActorId { get; set; }
        public int MovieId { get; set; }

        public List<Domen.Actor> Actors { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public double Income { get; set; }


    }
}
