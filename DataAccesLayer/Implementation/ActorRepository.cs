using Domen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{
    public class ActorRepository : IActorRepository
    {
        private readonly MovieContext context;

        public ActorRepository(MovieContext movieContext)
        {
            this.context = movieContext;
        }

        public void Add(Actor entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Actor entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }

        public List<Actor> GetAll()
        {
            return context.Actors.ToList();
        }

        public Actor GetSingle(Actor entity)
        {
            return context.Actors.Find(entity.PersonId);
        }

        public void Update(Actor entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
