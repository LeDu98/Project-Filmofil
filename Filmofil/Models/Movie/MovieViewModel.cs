using Domen;
using System;

namespace Filmofil.Models.Movie
{
    public class MovieViewModel
    {
        public int MovieId { get; set; }

        public string Name { get; set; }

        public string Genres { get; set; }

        public int Duration { get; set; }

        public DateTime Year { get; set; }

        public string Synopsis { get; set; }

        public double Rating { get; set; }

        public string Thumbnail { get; set; }

        public string Trailer { get; set; }

        public Studio Studio { get; set; }

        public StreamingService StreamingService { get; set; }
    }
}
