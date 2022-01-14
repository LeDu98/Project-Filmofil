using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Models
{
    public class ActorViewModel
    {
        public int PersonId{ get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Born { get; set; }

        public int CountryId { get; set; }

        public CountryViewModel Country { get; set; }

        public double Networth { get; set; }

        public string Image { get; set; }
    }
}
