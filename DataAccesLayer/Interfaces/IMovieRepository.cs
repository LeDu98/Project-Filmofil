﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public interface IMovieRepository : IRepository<Movie>
    {
        int GetMaxId();

        List<Movie> FindByGenre(string genre);
        List<Movie> FindByNameAndGenre(string searchText, string selectGenre);
    }
}
