using DataAccesLayer.Interfaces;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{
    public class GenreRepository : IGenreRepository
    {
        private readonly MovieContext context;

        public GenreRepository(MovieContext movieContext)
        {
            this.context = movieContext;
        }
        public void Add(Genre entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Genre entity)
        {
            throw new NotImplementedException();
        }

        public List<Genre> GetAll()
        {
            return context.Genres.ToList().OfType<Genre>().ToList();
        }

        public Genre GetSingle(Genre entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Genre entity)
        {
            throw new NotImplementedException();
        }
    }
}
