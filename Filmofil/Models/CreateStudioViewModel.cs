using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Models
{
    public class CreateStudioViewModel
    {
        [Required(ErrorMessage ="Obavezno polje!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string Headquarter { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        [DataType(DataType.Date)]
        public DateTime Founded { get; set; }
    }
}
