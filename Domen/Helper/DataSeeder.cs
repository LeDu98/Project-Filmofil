using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Helper
{
    public static class DataSeeder
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Studio>().HasData(
                new Studio
                {
                    StudioId = 1,
                    Name = "Universal Pictures",
                    Founded = new DateTime(1912, 3, 30),
                    Headquarter = "Universal City, California, United States",
                    LogoImg = "universal.png",
                    Website = "https://www.universalpictures.com/"
                },
                new Studio
                {
                    StudioId = 2,
                    Name = "Warner Bros. Pictures",
                    Founded = new DateTime(1923, 4, 4),
                    Headquarter = "Burbank, California, United States",
                    LogoImg = "Warner_Bros._(2019)_logo.svg.png",
                    Website = "https://www.warnerbros.com/"
                },
                new Studio
                {
                    StudioId = 3,
                    Name = "Sony Pictures",
                    Founded = new DateTime(1987, 12, 21),
                    Headquarter = "Culver City, California, United States",
                    LogoImg = "1200px-Sony_Pictures_Television_logo.svg.png",
                    Website = "https://www.sonypictures.com/"
                },
                new Studio
                {
                    StudioId = 4,
                    Name = "20th Century Studios",
                    Founded = new DateTime(1935, 5, 31),
                    Headquarter = "Los Angeles, California, United States",
                    LogoImg = "20th_Century_Studios_2020_logo.jpg",
                    Website = "https://www.20thcenturystudios.com/"
                },
                new Studio
                {
                    StudioId = 5,
                    Name = "Walt Disney Pictures",
                    Founded = new DateTime(1923, 1, 12),
                    Headquarter = "Burbank, California, United States",
                    LogoImg = "Walt_Disney_Pictures_2011_logo.png",
                    Website = "https://www.waltdisneystudios.com/"
                },
                new Studio
                {
                    StudioId = 6,
                    Name = "Metro-Goldwyn-Mayer",
                    Founded = new DateTime(1924, 4, 17),
                    Headquarter = "Los Angeles, California, United States",
                    LogoImg = "Metro-Goldwyn-Mayer_logo.png",
                    Website = "https://www.mgm.com/"
                }
                );

            modelBuilder.Entity<StreamingService>().HasData(
                new StreamingService
                {
                    StreamingServiceId = 1,
                    Name = "Netflix",
                    Headquarter = "Los Gatos, California, United States",
                    Founded = new DateTime(1997, 8, 29),
                    Price = 17.99,
                    Website = "https://netflix.com/",
                    LogoImg = "netflix.png"
                },
                new StreamingService
                {
                    StreamingServiceId = 2,
                    Name = "Amazon Prime Video",
                    Headquarter = "Seattle, Washington, United States",
                    Founded = new DateTime(2006, 9, 7),
                    Price = 12.99,
                    Website = "https://www.primevideo.com/",
                    LogoImg = "amazon-prime-video.png"
                },
                new StreamingService
                {
                    StreamingServiceId = 3,
                    Name = "Disney+",
                    Headquarter = "Burbank, California, United States",
                    Founded = new DateTime(2019, 11, 12),
                    Price = 7.99,
                    Website = "https://www.disneyplus.com/",
                    LogoImg = "disney-plus.png"
                },
                new StreamingService
                {
                    StreamingServiceId = 4,
                    Name = "HBO",
                    Headquarter = "New York, New York, United States",
                    Founded = new DateTime(1972, 11, 8),
                    Price = 9.99,
                    Website = "https://www.hbo.com/",
                    LogoImg = "hbo.png"
                },
                new StreamingService
                {
                    StreamingServiceId = 5,
                    Name = "Apple TV+",
                    Headquarter = "New York, New York, United States",
                    Founded = new DateTime(2019, 11, 1),
                    Price = 4.99,
                    Website = "https://www.apple.com/apple-tv-plus/",
                    LogoImg = "apple tv.png"
                }
                );

            

            modelBuilder.Entity<Actor>().HasData(
                new Actor
                {
                    PersonId = 1,
                    FirstName = "Leonardo",
                    LastName = "DiCaprio",
                    Born = new DateTime(1974, 10, 11),
                    CountryId = 1,
                    Networth = 260,
                    Image= "diCaprio.jpg"
                },
                new Actor
                {
                    PersonId = 2,
                    FirstName = "Jennifer",
                    LastName = "Lawrence",
                    Born = new DateTime(1990, 8, 15),
                    CountryId = 1,
                    Networth = 160,
                    Image = "jennifer-lawrence_gettyimages-626382596jpg.jpg"

                },
                new Actor
                {
                    PersonId = 3,
                    FirstName = "Meryl",
                    LastName = "Streep",
                    Born = new DateTime(1949, 6, 22),
                    CountryId = 1,
                    Networth = 160,
                    Image = "merylStreep.jpg"

                },
                new Actor
                {
                    PersonId = 4,
                    FirstName = "Jonah",
                    LastName = "Hill",
                    Born = new DateTime(1983, 12, 20),
                    CountryId = 1,
                    Networth = 50,
                    Image = "jonahHill.jpg"

                }, 
                new Actor
                {
                    PersonId = 6,
                    FirstName = "Freya",
                    LastName = "Allan",
                    Born = new DateTime(2001, 09, 06),
                    CountryId = 2,
                    Networth = 0.5,
                    Image = "freyaAllan.jpg"

                },
                new Actor
                {
                    PersonId = 7,
                    FirstName = "Emma",
                    LastName = "Watson",
                    Born = new DateTime(1990, 04, 15),
                    CountryId = 3,
                    Networth = 85,
                    Image = "emmaWatson.jpg"

                },
                new Actor
                {
                    PersonId = 8,
                    FirstName = "Daniel",
                    LastName = "Radcliffe",
                    Born = new DateTime(1989, 07, 23),
                    CountryId = 2,
                    Networth = 110,
                    Image = "danielRadcliffe.jfif"

                }
                );

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    Name = "United States"
                },
                new Country
                {
                    CountryId = 2,
                    Name = "United Kingdom"
                },
                new Country
                {
                    CountryId = 3,
                    Name = "France"
                }
                );

            modelBuilder.Entity<Personnel>().HasData(
                new Personnel
                {
                    PersonId = 5,
                    FirstName = "Adam",
                    LastName = "McKay",
                    Born = new DateTime(1968, 04, 17),
                    CountryId = 1,
                    Trademark = "Often begins his movies with a quote. Frequently works with Christian Bale, Steve Carell and Will Ferrell. Fast editing style."

                }
                );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "admin@gmail.com",
                    Username = "admin",
                    Password = "admin",
                    IsAdministrator = true
                },
                new User
                {
                    UserId = 2,
                    FirstName = "Milos",
                    LastName = "Vujic",
                    Email = "milosv@gmail.com",
                    Username = "milosv",
                    Password = "12345",
                    IsAdministrator = true
                },
                new User
                {
                    UserId = 3,
                    FirstName = "Dusan",
                    LastName = "Gajic",
                    Email = "dusang@gmail.com",
                    Username = "dusang",
                    Password = "12345",
                    IsAdministrator = true
                }
                );
              modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Name = "The Shawshank Redemption",
                    Duration=142,
                    Rating=9.3,
                    StreamingServiceId=1,
                    StudioId=1,
                    Genres="Drama",
                    Synopsis= "Chronicles the experiences of a formerly successful banker as a prisoner in the gloomy jailhouse of Shawshank after being found guilty of a crime he did not commit. The film portrays the man's unique way of dealing with his new, torturous life; along the way he befriends a number of fellow prisoners, most notably a wise long-term inmate named Red",
                    Thumbnail= "shawshank.png",
                    Trailer= "https://www.youtube.com/watch?v=6hB3S9bIaco",
                    Year=new DateTime(1994)
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "The Godfather",
                    Duration = 175,
                    Rating = 9.1,
                    StreamingServiceId = 2,
                    StudioId = 2,
                    Genres = "Crime, Drama",
                    Synopsis = "The Godfather Don Vito Corleone is the head of the Corleone mafia family in New York. He is at the event of his daughter's wedding. Michael, Vito's youngest son and a decorated WW II Marine is also present at the wedding. Michael seems to be uninterested in being a part of the family business. Vito is a powerful man, and is kind to all those who give him respect but is ruthless against those who do not. But when a powerful and treacherous rival wants to sell drugs and needs the Don's influence for the same, Vito refuses to do it. What follows is a clash between Vito's fading old values and the new ways which may cause Michael to do the thing he was most reluctant in doing and wage a mob war against all the other mafia families which could tear the Corleone family apart.",
                    Thumbnail = "godfather.jpg",
                    Trailer = "https://www.youtube.com/watch?v=sY1S34973zA",
                    Year = new DateTime(1972)
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "The Dark Knight",
                    Duration = 152,
                    Rating = 9.0,
                    StreamingServiceId = 3,
                    StudioId = 3,
                    Genres = "Action, Crime, Drama, Thriller",
                    Synopsis = "Set within a year after the events of Batman Begins (2005), Batman, Lieutenant James Gordon, and new District Attorney Harvey Dent successfully begin to round up the criminals that plague Gotham City, until a mysterious and sadistic criminal mastermind known only as The Joker appears in Gotham, creating a new wave of chaos. Batman's struggle against The Joker becomes deeply personal, forcing him to confront everything he believes and improve his technology to stop him. A love triangle develops between Bruce Wayne, Dent, and Rachel Dawes.",
                    Thumbnail = "darkKnight.png",
                    Trailer = "https://www.youtube.com/watch?v=EXeTwQWrcwY",
                    Year = new DateTime(2008)
                },
                new Movie
                {
                    MovieId = 4,
                    Name = "The Lord of the Rings: The Return of the King",
                    Duration = 201,
                    Rating = 8.9,
                    StreamingServiceId = 4,
                    StudioId = 4,
                    Genres = "Action, Adventure, Drama, Fantasy",
                    Synopsis= "The final confrontation between the forces of good and evil fighting for control of the future of Middle-earth. Frodo and Sam reach Mordor in their quest to destroy the One Ring, while Aragorn leads the forces of good against Sauron's evil army at the stone city of Minas Tirith.",
                    Thumbnail = "LOTR-3-The-Return-of-the-King-icon.png",
                    Trailer = "https://www.youtube.com/watch?v=r5X-hFf6Bwo",
                    Year = new DateTime(2003)
                }
                );
            modelBuilder.Entity<Acting>().HasData(
                new Acting
                {
                    ActorId=1,
                    MovieId=1,
                    Role="Police officer",
                    Income=7.5
                },
                new Acting
                {
                    ActorId = 2,
                    MovieId = 1,
                    Role = "Laywer",
                    Income = 2.5
                },
                new Acting
                {
                    ActorId = 3,
                    MovieId = 1,
                    Role = "Judge",
                    Income = 4.0
                },
                new Acting
                {
                    ActorId = 4,
                    MovieId = 2,
                    Role = "Don",
                    Income = 10.5
                },
                new Acting
                {
                    ActorId = 2,
                    MovieId = 2,
                    Role = "Laywer",
                    Income = 1.5
                },
                new Acting
                {
                    ActorId = 7,
                    MovieId = 2,
                    Role = "Dautgher",
                    Income = 0.75
                },
                new Acting
                {
                    ActorId = 8,
                    MovieId = 3,
                    Role = "Batman",
                    Income = 12.5
                },
                new Acting
                {
                    ActorId = 6,
                    MovieId = 3,
                    Role = "Jane Hawkins",
                    Income = 2.5
                },
                new Acting
                {
                    ActorId = 7,
                    MovieId = 3,
                    Role = "Adam",
                    Income = 4.0
                },
                new Acting
                {
                    ActorId = 1,
                    MovieId = 4,
                    Role = "Legolas",
                    Income = 7.2
                },
                new Acting
                {
                    ActorId = 3,
                    MovieId = 4,
                    Role = "Witch",
                    Income = 5.5
                },
                new Acting
                {
                    ActorId = 4,
                    MovieId = 4,
                    Role = "Gremlin",
                    Income = 5.0
                }

                );

        }

    }
}
    

