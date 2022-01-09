using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class StreamingService{

        public int StreamingServiceId { get; set; }

        public string Name { get; set; }

        public string Website { get; set; }

        public string LogoImg { get; set; }

        public string Headquarter { get; set; }

        public DateTime Founded { get; set; }

        public double Price { get; set; }

    }
}
