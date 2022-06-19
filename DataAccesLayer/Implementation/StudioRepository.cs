using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{
    public class StudioRepository : IStudioRepository
    {

        private readonly MovieContext context;

        public StudioRepository(MovieContext movieContext)
        {
            this.context = movieContext;
        }

        public void Add(Studio entity)
        {
            context.Add(entity);
            
        }

        public void Delete(Studio entity)
        {
            context.Remove(entity);
        }

        public List<Studio> Find(Studio entity)
        {
            throw new NotImplementedException();
        }

        public List<Studio> GetAll()
        {
            return context.Studio.ToList().OfType<Studio>().ToList();
        }

        public Studio GetSingle(Studio entity)
        {
            return context.Studio.Find(entity.StudioId);
        }

        public void Update(Studio entity)
        {
            context.Update(entity);
        }
    }
}
