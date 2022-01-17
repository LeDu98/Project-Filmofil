using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string Name { get; set; }

        public int Duration { get; set; }

        public DateTime Year { get; set; }

        public string Synopsis { get; set; }

        public string Genres { get; set; }

        public double Rating { get; set; }

        public string Thumbnail { get; set; }

        public string Trailer { get; set; }

        public int StudioId { get; set; }

        public Studio Studio { get; set; }

        public int StreamingServiceId { get; set; }

        public StreamingService StreamingService { get; set; }

        public List<Acting> Actings { get; set; }

        public List<Position> Positions { get; set; }

        public List<Review> Reviews { get; set; }
        

    }
}
