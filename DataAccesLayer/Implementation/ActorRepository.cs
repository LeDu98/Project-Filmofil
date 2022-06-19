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
        }

        public void Delete(Actor entity)
        {
            Console.WriteLine(entity);
            Actor actor = GetSingle(new Actor { PersonId = entity.PersonId });
            context.Remove(actor);
        }

        public List<Actor> Find(Actor entity)
        {
            throw new NotImplementedException();
        }

        public List<Actor> GetAll()
        {
            return context.Actors.Include(a=>a.Country).ToList();

            return context.Actors.OrderByDescending(o => o.Born).Where(o => o.CountryId == 1).Take(10).ToList();
        }

        public Actor GetSingle(Actor entity)
        { 
            var list = context.Actors.
                Include(a => a.Country).   
                ToList();
            return list.Find(a => a.PersonId == entity.PersonId);
        }

        public void Update(Actor entity)
        {
            context.Update(entity);
        }
    }
}
