using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Review
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int UserId { get; set; }
        public SiteUser User { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime Time { get; set; }
    }
}
