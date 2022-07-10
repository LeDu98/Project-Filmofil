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
        Task<bool> LoginAsync(SignInManager<SiteUser> signInManager, string username, string password);

        List<SiteUser> FindByString(string text);
     
    }
}
