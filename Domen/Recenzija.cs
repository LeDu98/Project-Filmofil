using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Recenzija{


        public int KorisnikId { get; set; }

        public Korisnik Korisnik { get; set; }

        public int FilmId { get; set; }

        public Film Film { get; set; }

        public int Ocena { get; set; }

        public string Komentar { get; set; }

        public DateTime Vreme { get; set; }

    }
}
