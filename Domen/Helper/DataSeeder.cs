﻿using Microsoft.EntityFrameworkCore;
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
                    LogoImg = "img/studioLogo/Universal_Pictures_logo_2.png",
                    Website = "https://www.universalpictures.com/"
                },
                new Studio
                {
                    StudioId = 2,
                    Name = "Warner Bros. Pictures",
                    Founded = new DateTime(1923, 4, 4),
                    Headquarter = "Burbank, California, United States",
                    LogoImg = "img/studioLogo/Warner_Bros._(2019)_logo.svg.png",
                    Website = "https://www.warnerbros.com/"
                },
                new Studio
                {
                    StudioId = 3,
                    Name = "Sony Pictures",
                    Founded = new DateTime(1987, 12, 21),
                    Headquarter = "Culver City, California, United States",
                    LogoImg = "img/studioLogo/1200px-Sony_Pictures_Television_logo.svg.png",
                    Website = "https://www.sonypictures.com/"
                },
                new Studio
                {
                    StudioId = 4,
                    Name = "20th Century Studios",
                    Founded = new DateTime(1935, 5, 31),
                    Headquarter = "Los Angeles, California, United States",
                    LogoImg = "img/studioLogo/20th_Century_Studios_2020_logo.jpg",
                    Website = "https://www.20thcenturystudios.com/"
                },
                new Studio
                {
                    StudioId = 5,
                    Name = "Walt Disney Pictures",
                    Founded = new DateTime(1923, 1, 12),
                    Headquarter = "Burbank, California, United States",
                    LogoImg = "img/studioLogo/Walt_Disney_Pictures_2011_logo.png",
                    Website = "https://www.waltdisneystudios.com/"
                },
                new Studio
                {
                    StudioId = 6,
                    Name = "Metro-Goldwyn-Mayer",
                    Founded = new DateTime(1924, 4, 17),
                    Headquarter = "Los Angeles, California, United States",
                    LogoImg = "img/studioLogo/Metro-Goldwyn-Mayer_logo.png",
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
                    LogoImg = "img/streamingServiceLogo/netflix.png"
                },
                new StreamingService
                {
                    StreamingServiceId = 2,
                    Name = "Amazon Prime Video",
                    Headquarter = "Seattle, Washington, United States",
                    Founded = new DateTime(2006, 9, 7),
                    Price = 12.99,
                    Website = "https://www.primevideo.com/",
                    LogoImg = "img/streamingServiceLogo/amazon-prime-video.png"
                },
                new StreamingService
                {
                    StreamingServiceId = 3,
                    Name = "Disney+",
                    Headquarter = "Burbank, California, United States",
                    Founded = new DateTime(2019, 11, 12),
                    Price = 7.99,
                    Website = "https://www.disneyplus.com/",
                    LogoImg = "img/streamingServiceLogo/disney-plus.png"
                },
                new StreamingService
                {
                    StreamingServiceId = 4,
                    Name = "HBO",
                    Headquarter = "New York, New York, United States",
                    Founded = new DateTime(1972, 11, 8),
                    Price = 9.99,
                    Website = "https://www.hbo.com/",
                    LogoImg = "img/streamingServiceLogo/hbo.png"
                },
                new StreamingService
                {
                    StreamingServiceId = 5,
                    Name = "Apple TV+",
                    Headquarter = "New York, New York, United States",
                    Founded = new DateTime(2019, 11, 1),
                    Price = 4.99,
                    Website = "https://www.apple.com/apple-tv-plus/",
                    LogoImg = "img/streamingServiceLogo/apple tv.png"
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
                    Networth = 260000000
                },
                new Actor
                {
                    PersonId = 2,
                    FirstName = "Jennifer",
                    LastName = "Lawrence",
                    Born = new DateTime(1990, 8, 15),
                    CountryId = 1,
                    Networth = 160000000

                },
                new Actor
                {
                    PersonId = 3,
                    FirstName = "Meryl",
                    LastName = "Streep",
                    Born = new DateTime(1949, 6, 22),
                    CountryId = 1,
                    Networth = 160000000

                },
                new Actor
                {
                    PersonId = 4,
                    FirstName = "Jonah",
                    LastName = "Hill",
                    Born = new DateTime(1983, 12, 20),
                    CountryId = 1,
                    Networth = 50000000

                }
                );

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    Name = "United States"
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

        }

    }
}
    

