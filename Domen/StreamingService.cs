using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class StreamingService{

        public int StreamingServiceId { get; set; }

        public string Naziv { get; set; }

        public string Sajt { get; set; }

        public string Sediste { get; set; }

        public DateTime DatumOsnivanja { get; set; }

        public double CenaPretplate { get; set; }

    }
}
