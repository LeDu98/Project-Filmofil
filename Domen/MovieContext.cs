using Domen.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Domen
{
    public class MovieContext:IdentityDbContext<SiteUser, IdentityRole<int>, int>
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Acting> Acting { get; set; }

        public DbSet<Personnel> Personnel { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<SiteUser> SiteUsers { get; set; }

        public DbSet<Studio> Studio { get; set; }

        public DbSet<StreamingService> StreamingService { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Country> Country { get; set; }

        public DbSet<Genre> Genres { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
            Database=Movies; Trusted_Connection=True");
        } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Acting>().HasKey(s =>new { s.ActorId, s.MovieId });
            modelBuilder.Entity<Review>().HasKey(s =>new { s.MovieId, s.UserId });
            modelBuilder.Entity<Position>().HasKey(s => new { s.PersonnelId, s.MovieId });

            modelBuilder.Entity<MovieGenre>().HasKey(s => new { s.GenreId, s.MovieId });

            modelBuilder.Entity<Actor>().HasBaseType<Person>().ToTable("Actors");

            modelBuilder.Entity<Personnel>().HasBaseType<Person>().ToTable("Personnel");

            modelBuilder.Seed();

        }
    }
}
