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
                });

            modelBuilder.Entity("Domen.Actor", b =>
                {
                    b.HasBaseType("Domen.Person");

                    b.Property<double>("Networth")
                        .HasColumnType("float");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Domen.Personnel", b =>
                {
                    b.HasBaseType("Domen.Person");

                    b.Property<string>("Trademark")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Personnel");
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
