using Domen.Helper;
using Microsoft.EntityFrameworkCore;
using System;

namespace Domen
{
    public class MovieContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Acting> Acting { get; set; }

        public DbSet<Personnel> Personnel { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Studio> Studio { get; set; }

        public DbSet<StreamingService> StreamingService { get; set; }

        public DbSet<Person> Persons { get; set; }


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

            modelBuilder.Entity<Actor>().HasBaseType<Person>().ToTable("Actors");

            modelBuilder.Entity<Personnel>().HasBaseType<Person>().ToTable("Personnel");
            modelBuilder.Seed();

        }
    }
}
