using Domen;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Filmofil.Models.Movie
{
    public class MovieCreateModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Year { get; set; }

        public string Synopsis { get; set; }

        public double Rating { get; set; }

        public IFormFile Thumbnail { get; set; }

        public string ThumbnailName { get; set; }

        public string Trailer { get; set; }
        [Required]
        public int StudioId { get; set; }

        public List<Studio> Studios { get; set; }
        [Required]
        public int StreamingServiceId { get; set; }

        public List<StreamingService> StreamingServices { get; set; }

        public List<SelectListItemActors> SelectListItemActors { get; set; }
       
        public List<Acting> Actings { get; set; }
        
        public List<Position> Positions { get; set; }

        public List<SelectListItemPersonnel> SelectListItemPersonnel { get; set; }

        public List<MovieGenre> MovieGenres { get; set; }

        public List<Genre> Genres { get; set; }
        [Required(ErrorMessage = "The Movie must have at least one genre!")]
        public int[] GenreIds { get; set; }

    }

    public class SelectListItemActors
    {
        public Domen.Actor Actor { get; set; }

        public bool IsSelected { get; set; }

    }


    public class SelectListItemPersonnel
    {
        public Domen.Personnel Personnel { get; set; }

        public bool IsSelected { get; set; }

    }
}