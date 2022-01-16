﻿using Domen;
using System;
using System.Collections.Generic;

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

        public List<Domen.Actor> Actors { get; set; }

        public List<Domen.Personnel> Personnels { get; set; }


        /* Mozda ova dole tri ne trebaju */

        public List<Acting> Actings { get; set; }

        public List<Position> Positions { get; set; }

        public List<Review> Reviews { get; set; }

    }
}
