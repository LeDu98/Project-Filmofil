using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Models.Movie
{
    public class MovieIndexViewModel
    {
        public List<Domen.Movie> Movies { get; set; }

        public int GenreId { get; set; }

        public List<Domen.Genre> Genres { get; set; }

        public string SearchText { get; set; }
    }
}
