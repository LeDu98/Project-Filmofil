using Domen;
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

        public List<SiteUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public SiteUser GetSingle(SiteUser entity)
        {
            return context.SiteUsers.Find(entity.UserName);
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
