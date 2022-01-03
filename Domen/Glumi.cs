using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Glumi
    {
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int GlumacId { get; set; }
        public Glumac Glumac { get; set; }
        public string NazivUloge { get; set; }
        public double Honorar { get; set; }
    }
}
