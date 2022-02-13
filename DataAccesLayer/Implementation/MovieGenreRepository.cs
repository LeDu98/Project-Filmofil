using DataAccesLayer.Interfaces;
using Domen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{
    public class MovieGenreRepository : IMovieGenreRepository
    {
        private MovieContext context;

        public MovieGenreRepository(MovieContext context)
        {
            this.context = context;
        }

        public void Add(MovieGenre entity)
        {
            context.Add(entity);
        }

        
        public void Delete(MovieGenre entity)
        {
            context.Remove(entity);
        }

        public List<MovieGenre> GetAll()
        {
            return context.MovieGenre.Include(m=>m.Genre).Include(m=>m.Movie).ToList();
        }

        public MovieGenre GetSingle(MovieGenre entity)
        {
            throw new NotImplementedException();
        }

        public void Update(MovieGenre entity)
        {
            throw new NotImplementedException();
        }
    }
}
