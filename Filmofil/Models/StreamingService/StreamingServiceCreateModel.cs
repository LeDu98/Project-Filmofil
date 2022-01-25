using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace Filmofil.Models
{
    public class StreamingServiceCreateModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Website { get; set; }

        public IFormFile Img { get; set; }

        public string ImageName { get; set; }
        [Required]
        public string Headquarter { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [DataType(DataType.Date)]
        public DateTime Founded { get; set; }
        [Required]
        public double Price { get; set; }

    }
}
