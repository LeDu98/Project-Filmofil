using Domen;
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

        public List<Personnel> GetAll()
        {
            return context.Personnel.ToList();
        }

        public Personnel GetSingle(Personnel entity)
        {
            return context.Personnel.Find(entity.PersonId);
        }

        public void Update(Personnel entity)
        {
            context.Update(entity);
        }
    }
}
