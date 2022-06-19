using Domen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{
    internal class ActingRepository : IActingRepository
    {

        private readonly MovieContext context;

        public ActingRepository(MovieContext movieContext)
        {
            this.context = movieContext;
        }

        public void Add(Acting entity)
        {
            context.Add(entity);
        }

        public void Delete(Acting entity)
        {
            context.Remove(entity);
        }

        public List<Acting> Find(Acting entity)
        {
            throw new NotImplementedException();
        }

        public List<Acting> GetAll()
        {
            return context.Acting.Include(a=>a.Movie).
                ToList();
        }

        public Acting GetSingle(Acting entity)
        {
            return context.Acting.Find(entity.MovieId,entity.ActorId);
        }

        

        public void Update(Acting entity)
        {
            context.Update(entity);
        }
    }
}
