using Filmofil.Models.Movie;
using System.Collections.Generic;

namespace Filmofil.Models.Home
{
    public class HomeViewModel
    {

        public List<Domen.Movie> NewReleases { get; set; }

        public List<Domen.Movie> TopRated { get; set; }

        public List<Domen.MovieGenre> Action { get; set; }

        public List<Domen.MovieGenre> Comedy { get; set; }

        public List<Domen.MovieGenre> Drama { get; set; }

        public List<Domen.MovieGenre> Fantasy { get; set; }

        public List<Domen.MovieGenre> Horror { get; set; }

        public List<Domen.MovieGenre> Mystery { get; set; }

        public List<Domen.MovieGenre> Romance { get; set; }

        public List<Domen.MovieGenre> Thriller { get; set; }

        public List<Domen.MovieGenre> Western { get; set; }

        public List<Domen.MovieGenre> Crime { get; set; }

        public List<Domen.MovieGenre> Adventure { get; set; }

        public List<Domen.MovieGenre> SciFi { get; set; }

        public List<Domen.MovieGenre> Biography { get; set; }



    }
}
