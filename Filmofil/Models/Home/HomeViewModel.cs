using Filmofil.Models.Movie;
using System.Collections.Generic;

namespace Filmofil.Models.Home
{
    public class HomeViewModel
    {

        public List<Domen.Movie> ListOfMovies { get; set; }

        public List<Domen.MovieGenre> ListOfMovieGenres { get; set; }

    }
}
