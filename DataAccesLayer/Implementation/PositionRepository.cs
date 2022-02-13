using Domen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{
    public class PositionRepository : IPositionRepository
    {
        private readonly MovieContext context;

        public PositionRepository(MovieContext movieContext)
        {
            this.context = movieContext;
        }

        public void Add(Position entity)
        {
            context.Add(entity);
        }

        public void Delete(Position entity)
        {
            context.Remove(entity);
        }

        public List<Position> GetAll()
        {
            return context.Positions.Include(p => p.Movie).
                ToList();
        }

        public Position GetSingle(Position entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Position entity)
        {
            throw new NotImplementedException();
        }
    }
}
