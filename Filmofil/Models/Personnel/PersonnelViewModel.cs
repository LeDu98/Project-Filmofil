﻿using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Models.Personnel
{
    public class PersonnelViewModel
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Born { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public string Trademark { get; set; }

        public string Image { get; set; }

        public List<Position> Positions { get; set; }

        public bool IsAdmin { get; set; }
    }
}
