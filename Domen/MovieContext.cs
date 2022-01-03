using Microsoft.EntityFrameworkCore;
using System;

namespace Domen
{
    public class MovieContext:DbContext
    {
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Acting> Acting { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
            Database=Movies; Trusted_Connection=True");
        } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acting>().HasKey(s =>new { s.ActorId, s.MovieId });
            modelBuilder.Entity<Review>().HasKey(s =>new { s.MovieId, s.UserId });
            modelBuilder.Entity<Position>().HasKey(s => new { s.PersonnelId, s.MovieId });
            
        }
    }
}
