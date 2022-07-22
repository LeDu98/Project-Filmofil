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

      
        public List<Actor> Find(string text)
        {
            return context
                .Actors
                .Where(a => String.Concat(a.FirstName, " ", a.LastName).ToLower().Contains(text.ToLower()) || 
                String.Concat(a.LastName, " ", a.FirstName).ToLower().Contains(text.ToLower()))
                .ToList();
        }

        public List<Actor> GetAll()
        {
            return context.Actors.Include(a=>a.Country).ToList();

        }

        public Actor GetSingle(Actor entity)
        {
            var actor = context.Actors.
                Include(a => a.Country).
                SingleOrDefault(a => a.PersonId == entity.PersonId);
            return actor;
        }

        public void Update(Actor entity)
        {
            context.Update(entity);
        }
    }
}
