using Domen;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{

    public class SiteUserRepository : ISiteUserRepository
    {

        private readonly MovieContext context;

        public SiteUserRepository(MovieContext context)
        {
            this.context = context;
        }

        public void Add(SiteUser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SiteUser entity)
        {
            throw new NotImplementedException();
        }

        public List<SiteUser> Find(Movie entity)
        {
            throw new NotImplementedException();
        }

        public List<SiteUser> Find(SiteUser entity)
        {
            throw new NotImplementedException();
        }

        public List<SiteUser> GetAll()
        {
            return context.SiteUsers.ToList();
        }

        public SiteUser GetSingle(SiteUser entity)
        {
            return context.SiteUsers.Find(entity.UserName);
        }

        public async Task<bool> LoginAsync(SignInManager<SiteUser> signInManager, string username, string password)
        {
            var result= await signInManager.PasswordSignInAsync(username, password, false, false);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
            
        }

        public SiteUser SearchByUsername(string username)
        {
            return context.SiteUsers.SingleOrDefault(su => su.UserName == username);
        }

        public void Update(SiteUser entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> ISiteUserRepository.LoginAsync(SignInManager<SiteUser> signInManager, string username, string password)
        {
            Task<bool> result = LoginAsync(signInManager, username, password);

            return result;
        }
    }
}
