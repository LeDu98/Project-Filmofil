using Domen;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Models.Personnel
{
    public class CreatePersonnelViewModel
    {
        
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [DataType(DataType.Date)]
        public DateTime Born { get; set; }


        public int CountryId { get; set; }

        public List<Country> Countries { get; set; }

        public IFormFile Image { get; set; }

        public string ImageName { get; set; }

        public string Trademark { get; set; }
    }
}
