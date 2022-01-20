using Domen;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Filmofil.Models.Movie
{
    public class MovieCreateModel
    {
        public string Name { get; set; }

        public int Duration { get; set; }

        public DateTime Year { get; set; }

        public string Synopsis { get; set; }

        public double Rating { get; set; }

        public IFormFile Thumbnail { get; set; }

        public string Trailer { get; set; }

        public int StudioId { get; set; }

        public List<Studio> Studios { get; set; }

        public int StreamingServiceId { get; set; }

        public List<StreamingService> StreamingServices { get; set; }

        public List<Domen.Actor> Actors { get; set; }

        public List<Domen.Personnel> Personnels { get; set; }

        public List<Genre> Genres { get; set; }

        public int[] GenreIds { get; set; }

    }
}
