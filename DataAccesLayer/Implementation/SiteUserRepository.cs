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

       
      

        public List<SiteUser> Find(string text)
        {
            throw new NotImplementedException();
        }

        public List<SiteUser> FindByString(string text)
        {
            if(text=="" || text == null)
            {
                return context.SiteUsers.ToList();
            }

            return context.SiteUsers.ToList().Where(su => String.Concat(su.FirstName, " ", su.LastName).ToLower().Contains(text.ToLower()) || String.Concat(su.LastName, " ", su.FirstName).ToLower().Contains(text.ToLower()) || su.UserName.ToLower().Contains(text.ToLower())).ToList();
        }

        public List<SiteUser> GetAll()
        {
            return context.SiteUsers.ToList();
        }

        public SiteUser GetSingle(SiteUser entity)
        {
            return context.SiteUsers.Find(entity.Id);
        }

       
        public SiteUser SearchByUsername(string username)
        {
            return context.SiteUsers.SingleOrDefault(su => su.UserName == username);
        }

        public void Update(SiteUser entity)
        {
            throw new NotImplementedException();
        }

       

       
    }
}
