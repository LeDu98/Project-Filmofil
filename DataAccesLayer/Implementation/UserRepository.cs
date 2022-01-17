using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{

    public class UserRepository : IUserRepository
    {

        private readonly MovieContext context;

        public UserRepository(MovieContext context)
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
            throw new NotImplementedException();
        }

        public SiteUser SearchByUsernamePassword(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Update(SiteUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
