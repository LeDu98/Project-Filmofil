﻿// <auto-generated />
using System;
using Domen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domen.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domen.Acting", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<double>("Income")
                        .HasColumnType("float");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Acting");
                });

            modelBuilder.Entity("Domen.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "United States"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "United Kingdom"
                        },
                        new
                        {
                            CountryId = 3,
                            Name = "France"
                        });
                });

            modelBuilder.Entity("Domen.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Genres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("StreamingServiceId")
                        .HasColumnType("int");

                    b.Property<int>("StudioId")
                        .HasColumnType("int");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.HasIndex("StreamingServiceId");

                    b.HasIndex("StudioId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Domen.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Born")
                        .HasColumnType("datetime2");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.HasIndex("CountryId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Domen.Position", b =>
                {
                    b.Property<int>("PersonnelId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("PositionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonnelId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Domen.Review", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("MovieId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Domen.StreamingService", b =>
                {
                    b.Property<int>("StreamingServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Founded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Headquarter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StreamingServiceId");

                    b.ToTable("StreamingService");

                    b.HasData(
                        new
                        {
                            StreamingServiceId = 1,
                            Founded = new DateTime(1997, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headquarter = "Los Gatos, California, United States",
                            LogoImg = "netflix.png",
                            Name = "Netflix",
                            Price = 17.989999999999998,
                            Website = "https://netflix.com/"
                        },
                        new
                        {
                            StreamingServiceId = 2,
                            Founded = new DateTime(2006, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headquarter = "Seattle, Washington, United States",
                            LogoImg = "amazon-prime-video.png",
                            Name = "Amazon Prime Video",
                            Price = 12.99,
                            Website = "https://www.primevideo.com/"
                        },
                        new
                        {
                            StreamingServiceId = 3,
                            Founded = new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headquarter = "Burbank, California, United States",
                            LogoImg = "disney-plus.png",
                            Name = "Disney+",
                            Price = 7.9900000000000002,
                            Website = "https://www.disneyplus.com/"
                        },
                        new
                        {
                            StreamingServiceId = 4,
                            Founded = new DateTime(1972, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headquarter = "New York, New York, United States",
                            LogoImg = "hbo.png",
                            Name = "HBO",
                            Price = 9.9900000000000002,
                            Website = "https://www.hbo.com/"
                        },
                        new
                        {
                            StreamingServiceId = 5,
                            Founded = new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headquarter = "New York, New York, United States",
                            LogoImg = "apple tv.png",
                            Name = "Apple TV+",
                            Price = 4.9900000000000002,
                            Website = "https://www.apple.com/apple-tv-plus/"
                        });
                });

            modelBuilder.Entity("Domen.Studio", b =>
                {
                    b.Property<int>("StudioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Founded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Headquarter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudioId");

                    b.ToTable("Studio");

                    b.HasData(
                        new
                        {
                            StudioId = 1,
                            Founded = new DateTime(1912, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headquarter = "Universal City, California, United States",
                            LogoImg = "universal.png",
                            Name = "Universal Pictures",
                            Website = "https://www.universalpictures.com/"
                        },
                        new
                        {
                            StudioId = 2,
                            Founded = new DateTime(1923, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headquarter = "Burbank, California, United States",
                            LogoImg = "Warner_Bros._(2019)_logo.svg.png",
                            Name = "Warner Bros. Pictures",
                            Website = "https://www.warnerbros.com/"
                        },
                        new
                        {
                            StudioId = 3,
                            Founded = new DateTime(1987, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headquarter = "Culver City, California, United States",
                            LogoImg = "1200px-Sony_Pictures_Television_logo.svg.png",
                            Name = "Sony Pictures",
                            Website = "https://www.sonypictures.com/"
                        },
                        new
                        {
                            StudioId = 4,
                            Founded = new DateTime(1935, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headquarter = "Los Angeles, California, United States",
                            LogoImg = "20th_Century_Studios_2020_logo.jpg",
                            Name = "20th Century Studios",
                            Website = "https://www.20thcenturystudios.com/"
                        },
                        new
                        {
                            StudioId = 5,
                            Founded = new DateTime(1923, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headquarter = "Burbank, California, United States",
                            LogoImg = "Walt_Disney_Pictures_2011_logo.png",
                            Name = "Walt Disney Pictures",
                            Website = "https://www.waltdisneystudios.com/"
                        },
                        new
                        {
                            StudioId = 6,
                            Founded = new DateTime(1924, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headquarter = "Los Angeles, California, United States",
                            LogoImg = "Metro-Goldwyn-Mayer_logo.png",
                            Name = "Metro-Goldwyn-Mayer",
                            Website = "https://www.mgm.com/"
                        });
                });

            modelBuilder.Entity("Domen.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdministrator")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "admin@gmail.com",
                            FirstName = "Admin",
                            IsAdministrator = true,
                            LastName = "Admin",
                            Password = "admin",
                            Username = "admin"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "milosv@gmail.com",
                            FirstName = "Milos",
                            IsAdministrator = true,
                            LastName = "Vujic",
                            Password = "12345",
                            Username = "milosv"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "dusang@gmail.com",
                            FirstName = "Dusan",
                            IsAdministrator = true,
                            LastName = "Gajic",
                            Password = "12345",
                            Username = "dusang"
                        });
                });

            modelBuilder.Entity("Domen.Actor", b =>
                {
                    b.HasBaseType("Domen.Person");

                    b.Property<double>("Networth")
                        .HasColumnType("float");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            Born = new DateTime(1974, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 1,
                            FirstName = "Leonardo",
                            Image = "diCaprio.jpg",
                            LastName = "DiCaprio",
                            Networth = 260000000.0
                        },
                        new
                        {
                            PersonId = 2,
                            Born = new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 1,
                            FirstName = "Jennifer",
                            Image = "jennifer-lawrence_gettyimages-626382596jpg.jpg",
                            LastName = "Lawrence",
                            Networth = 160000000.0
                        },
                        new
                        {
                            PersonId = 3,
                            Born = new DateTime(1949, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 1,
                            FirstName = "Meryl",
                            Image = "merylStreep.jpg",
                            LastName = "Streep",
                            Networth = 160000000.0
                        },
                        new
                        {
                            PersonId = 4,
                            Born = new DateTime(1983, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 1,
                            FirstName = "Jonah",
                            Image = "jonahHill.jpg",
                            LastName = "Hill",
                            Networth = 50000000.0
                        },
                        new
                        {
                            PersonId = 6,
                            Born = new DateTime(2001, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 2,
                            FirstName = "Freya",
                            Image = "freyaAllan.jpg",
                            LastName = "Allan",
                            Networth = 500000.0
                        },
                        new
                        {
                            PersonId = 7,
                            Born = new DateTime(1990, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 3,
                            FirstName = "Emma",
                            Image = "emmaWatson.jpg",
                            LastName = "Watson",
                            Networth = 85000000.0
                        },
                        new
                        {
                            PersonId = 8,
                            Born = new DateTime(1989, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 2,
                            FirstName = "Daniel",
                            Image = "danielRadcliffe.jfif",
                            LastName = "Radcliffe",
                            Networth = 110000000.0
                        });
                });

            modelBuilder.Entity("Domen.Personnel", b =>
                {
                    b.HasBaseType("Domen.Person");

                    b.Property<string>("Trademark")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Personnel");

                    b.HasData(
                        new
                        {
                            PersonId = 5,
                            Born = new DateTime(1968, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 1,
                            FirstName = "Adam",
                            LastName = "McKay",
                            Trademark = "Often begins his movies with a quote. Frequently works with Christian Bale, Steve Carell and Will Ferrell. Fast editing style."
                        });
                });

            modelBuilder.Entity("Domen.Acting", b =>
                {
                    b.HasOne("Domen.Actor", "Actor")
                        .WithMany()
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domen.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Domen.Movie", b =>
                {
                    b.HasOne("Domen.StreamingService", "StreamingService")
                        .WithMany()
                        .HasForeignKey("StreamingServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domen.Studio", "Studio")
                        .WithMany()
                        .HasForeignKey("StudioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StreamingService");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("Domen.Person", b =>
                {
                    b.HasOne("Domen.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Domen.Position", b =>
                {
                    b.HasOne("Domen.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domen.Personnel", "Personnel")
                        .WithMany()
                        .HasForeignKey("PersonnelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("Domen.Review", b =>
                {
                    b.HasOne("Domen.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domen.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domen.Actor", b =>
                {
                    b.HasOne("Domen.Person", null)
                        .WithOne()
                        .HasForeignKey("Domen.Actor", "PersonId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domen.Personnel", b =>
                {
                    b.HasOne("Domen.Person", null)
                        .WithOne()
                        .HasForeignKey("Domen.Personnel", "PersonId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
