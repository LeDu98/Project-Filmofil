using Microsoft.AspNetCore.Http;
using System;

namespace Filmofil.Models
{
    public class StreamingServiceCreateModel
    {

        public string Name { get; set; }

        public string Website { get; set; }

        public IFormFile Img { get; set; }

        public string Headquarter { get; set; }

        public DateTime Founded { get; set; }

        public double Price { get; set; }

    }
}
