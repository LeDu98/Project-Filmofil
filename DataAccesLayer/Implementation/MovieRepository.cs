using Domen;
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

        public List<Movie> GetAll()
        {
            return context.Movies.ToList().OfType<Movie>().ToList();
        }

        public Movie GetSingle(Movie entity)
        {
            return context.Movies.Find(entity.MovieId);
        }

        public void Update(Movie entity)
        {
            context.Update(entity);
        }
    }
}
