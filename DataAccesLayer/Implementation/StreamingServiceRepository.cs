using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{
    public class StreamingServiceRepository : IStreamingServiceRepository
    {

        private readonly MovieContext context;

        public StreamingServiceRepository(MovieContext movieContext)
        {
            this.context = movieContext;
        }

        public void Add(StreamingService entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(StreamingService entity)
        {
            throw new NotImplementedException();
        }

        public List<StreamingService> GetAll()
        {
            return context.StreamingService.ToList().OfType<StreamingService>().ToList();
        }

        public StreamingService GetSingle(StreamingService entity)
        {
            throw new NotImplementedException();
        }

        public void Update(StreamingService entity)
        {
            throw new NotImplementedException();
        }
    }
}
