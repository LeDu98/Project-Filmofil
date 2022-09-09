using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Views.Shared.SearchBar
{
    public class SPager
    {
        public SPager()
        {

        }
        public string SearchText { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public string SelectedGenre { get; set; }


    }
}
