using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Models
{
    public class CreateStudioViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Headquarter { get; set; }
        //[Required(ErrorMessage = "Obavezno polje!")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime Founded { get; set; }

        public string Website { get; set; }

        public IFormFile LogoImg { get; set; }
    }
}
