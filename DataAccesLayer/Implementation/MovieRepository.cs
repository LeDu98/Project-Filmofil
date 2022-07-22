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

        public List<Movie> Find(string text)
        {
            return context.Movies.Include(m => m.Studio).
                Include(m => m.StreamingService).
                Include(m => m.Genres).
                Where(m => m.Name.ToLower().Contains(text.ToLower()))
                .ToList();
        }

        public List<Movie> FindByGenre(string genre)
        {
            return context.Movies.Include(m => m.Studio).
                Include(m => m.StreamingService).
                Include(m => m.Genres).
                Where(m => m.Genres.Any(g => g.Genre.Name == genre))
                .ToList();
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
            var movie = context.Movies.
                Include(m => m.Studio).
                Include(m => m.StreamingService).
                Include(m => m.Actings).
                Include(m => m.Positions).
                Include(m => m.Reviews).
                Include(m => m.Genres).
                SingleOrDefault(m => m.MovieId == entity.MovieId);
            return movie;
        }

        public void Update(Movie entity)
        {
            context.Update(entity);
        }
    }
}
