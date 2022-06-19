using Domen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{
    public class MovieRepository : IMovieRepository
    {

        private readonly MovieContext context;

        public MovieRepository(MovieContext movieContext)
        {
            this.context = movieContext;
        }

        public void Add(Movie entity)
        {
            context.Add(entity);
            
        }

        public void Delete(Movie entity)
        {
            context.Remove(entity);
        }

        public List<Movie> Find(Movie entity)
        {
            return context.Movies.ToList().FindAll(m => m.Name.ToLower().Contains(entity.Name));
        }

        public List<Movie> GetAll()
        {
            return context.Movies.
                Include(m => m.Studio).
                Include(m => m.StreamingService).
                Include(m => m.Genres).
                ToList();

        }

        public int GetMaxId()
        {
           return context.Movies.Max(u => u.MovieId);
        }

        public Movie GetSingle(Movie entity)
        {
            var list = context.Movies.
                Include(m => m.Studio).
                Include(m => m.StreamingService).
                Include(m => m.Actings).
                Include(m => m.Positions).
                Include(m => m.Reviews).
                Include(m => m.Genres).
                ToList();
            return list.Find( m => m.MovieId == entity.MovieId );
        }

        public void Update(Movie entity)
        {
            context.Update(entity);
        }
    }
}
