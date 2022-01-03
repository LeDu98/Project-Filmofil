using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Naziv { get; set; }
        public string Zanr { get; set; }
        public int Trajanje { get; set; }
        public double Ocena { get; set; }
        public string Thumbnail { get; set; }
        public string Trailer { get; set; }
        public int StudioId { get; set; }
        public Studio Studio { get; set; }

    }
}
