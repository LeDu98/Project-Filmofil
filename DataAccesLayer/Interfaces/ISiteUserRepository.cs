using Domen;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public interface ISiteUserRepository : IRepository<SiteUser>
    {
        SiteUser SearchByUsername(string username);
       
        List<SiteUser> FindByString(string text);
     
    }
}
