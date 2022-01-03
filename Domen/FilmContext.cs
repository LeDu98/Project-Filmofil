using Microsoft.EntityFrameworkCore;
using System;

namespace Domen
{
    public class FilmContext:DbContext
    {
        public DbSet<Film> Films { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
            Database=Filmofil; Trusted_Connection=True");
        } 
    }
}
