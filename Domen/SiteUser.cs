using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
   public class SiteUser:IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsAdministrator { get; set; }

       // public List<Movie> Movies { get; set; }
    }
}
