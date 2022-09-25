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
            context.Add(entity);
        }

        public void Delete(StreamingService entity)
        {
            context.Remove(entity);
        }

        

        public List<StreamingService> Find(string text)
        {
            return context.StreamingService.Where(s => s.Name.ToLower().Contains(text.ToLower())).ToList();
        }

        public List<StreamingService> GetAll()
        {
            return context.StreamingService.ToList();
        }

        public StreamingService GetSingle(StreamingService entity)
        {
            return context.StreamingService.Find(entity.StreamingServiceId);
        }

        public void Update(StreamingService entity)
        {
            context.Update(entity);
        }
    }
}
