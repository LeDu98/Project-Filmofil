﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Models
{
    public class StudioViewModel
    {
        public int StudioId { get; set; }
        public string Name { get; set; }

        public string Headquarter { get; set; }

        public DateTime Founded { get; set; }

        public string LogoImg { get; set; }

        public string Website { get; set; }
    }
}
