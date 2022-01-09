using System;
using System.ComponentModel.DataAnnotations;

namespace Filmofil.Models
{
    public class StreamingServiceViewModel
    {
        public string Name { get; set; }

        public string Website { get; set; }

        public string LogoImg { get; set; }

        public string Headquarter { get; set; }

        [DataType(DataType.Date)]
        public DateTime Founded { get; set; }

        public double Price { get; set; }

    }
}
