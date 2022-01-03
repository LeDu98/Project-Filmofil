using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Position
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int PersonnelId { get; set; }
        public Personnel Personnel { get; set; }
        public string PositionTitle { get; set; }
    }
}
