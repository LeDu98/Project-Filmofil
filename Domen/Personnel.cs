using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
   public class Personnel
    {
        public int PersonnelId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
