using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{
    public class CountryRepository : ICountryRepository
    {
        private readonly MovieContext context;

        public CountryRepository(MovieContext movieContext)
        {
            this.context = movieContext;
        }
        public void Add(Country entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Country entity)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAll()
        {
            return context.Country.ToList().OfType<Country>().ToList();
        }

        public Country GetSingle(Country entity)
        {
            return context.Country.Find(entity.CountryId);
        }

        public void Update(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
