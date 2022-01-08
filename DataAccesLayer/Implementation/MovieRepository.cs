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
            throw new NotImplementedException();
        }

        public void Delete(Movie entity)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            //return context.Movies.ToList().OfType<Movie>().ToList();

            return new List<Movie> {
                new Movie()
                {
                    Name = "test1"
                },
                new Movie()
                {
                    Name = "test2"
                },
                new Movie()
                {
                    Name = "test3"
                },
            };

        }

        public void Update(Movie entity)
        {
            throw new NotImplementedException();
        }
    }
}
