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

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User SearchByUsernamePassword(string username, string password)
        {
            return context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
