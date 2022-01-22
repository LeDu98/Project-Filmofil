using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Models.Movie
{
    public class CreateMoviePersonnelViewModel
    {
        public int PersonnelId { get; set; }
        public int MovieId { get; set; }

        public List<Domen.Personnel> Personnels { get; set; }
        [Required]
        public string PositionTitle { get; set; }

    }
}
