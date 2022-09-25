using Domen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{
    public class PersonnelRepository : IPersonnelRepository
    {
        private readonly MovieContext context;

        public PersonnelRepository(MovieContext movieContext)
        {
            this.context = movieContext;
        }

        public void Add(Personnel entity)
        {
            context.Add(entity);
        }

        public void Delete(Personnel entity)
        {
            context.Remove(entity);
        }

        public List<Personnel> Find(string text)
        {
            return context.Personnel.ToList().FindAll(p => p.FirstName.ToLower().Contains(text) || p.LastName.ToLower().Contains(text));
        }

        public List<Personnel> GetAll()
        {
            return context.Personnel.Include(p=>p.Country).ToList();
        }

        public Personnel GetSingle(Personnel entity)
        {
            var list = context.Personnel.
                Include(p => p.Country).
                ToList();
            return list.Find(p => p.PersonId == entity.PersonId);
           
        }

        public void Update(Personnel entity)
        {
            context.Update(entity);
        }
    }
}
