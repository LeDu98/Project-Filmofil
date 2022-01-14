using Domen;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Models.Actor
{
    public class CreateActorViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Born { get; set; }


        public int CountryId { get; set; }

        public List<Country> Countries { get; set; }

        public IFormFile Image { get; set; }

        public string ImageName { get; set; }

        public double Networth { get; set; }
    }
}
