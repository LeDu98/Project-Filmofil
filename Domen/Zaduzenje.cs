using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
   public class Zaduzenje
    {
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int UcesnikId { get; set; }
        public Ucesnik Ucesnik { get; set; }
        public string NazivZaduzenja { get; set; }
    }
}
