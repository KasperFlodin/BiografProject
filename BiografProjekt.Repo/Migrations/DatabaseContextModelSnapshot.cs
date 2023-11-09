﻿// <auto-generated />
using BiografProjekt.Repo.Dbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BiografProjekt.Repo.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BiografProjekt.Repo.DTO.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Phychological"
                        },
                        new
                        {
                            Id = 7,
                            Name = "sci fi"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Crime"
                        });
                });

            modelBuilder.Entity("BiografProjekt.Repo.DTO.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Hall");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 1,
                            NumberOfSeats = 5
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 2,
                            NumberOfSeats = 5
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 3,
                            NumberOfSeats = 5
                        });
                });

            modelBuilder.Entity("BiografProjekt.Repo.DTO.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseDate")
                        .HasColumnType("int");

                    b.Property<int>("length")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId")
                        .IsUnique();

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreId = 2,
                            Name = "first",
                            ReleaseDate = 2020,
                            length = 140
                        },
                        new
                        {
                            Id = 2,
                            GenreId = 3,
                            Name = "second",
                            ReleaseDate = 2020,
                            length = 110
                        },
                        new
                        {
                            Id = 3,
                            GenreId = 1,
                            Name = "third",
                            ReleaseDate = 2020,
                            length = 120
                        },
                        new
                        {
                            Id = 4,
                            GenreId = 4,
                            Name = "fourth",
                            ReleaseDate = 2024,
                            length = 140
                        },
                        new
                        {
                            Id = 5,
                            GenreId = 5,
                            Name = "fifth",
                            ReleaseDate = 2020,
                            length = 130
                        },
                        new
                        {
                            Id = 6,
                            GenreId = 6,
                            Name = "sixth",
                            ReleaseDate = 2020,
                            length = 130
                        },
                        new
                        {
                            Id = 7,
                            GenreId = 8,
                            Name = "seventh",
                            ReleaseDate = 2020,
                            length = 180
                        });
                });

            modelBuilder.Entity("BiografProjekt.Repo.DTO.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Seat");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SeatNumber = 1
                        },
                        new
                        {
                            Id = 2,
                            SeatNumber = 2
                        },
                        new
                        {
                            Id = 3,
                            SeatNumber = 3
                        },
                        new
                        {
                            Id = 4,
                            SeatNumber = 4
                        },
                        new
                        {
                            Id = 5,
                            SeatNumber = 5
                        },
                        new
                        {
                            Id = 6,
                            SeatNumber = 6
                        },
                        new
                        {
                            Id = 7,
                            SeatNumber = 7
                        },
                        new
                        {
                            Id = 8,
                            SeatNumber = 8
                        },
                        new
                        {
                            Id = 9,
                            SeatNumber = 9
                        },
                        new
                        {
                            Id = 10,
                            SeatNumber = 10
                        },
                        new
                        {
                            Id = 11,
                            SeatNumber = 11
                        },
                        new
                        {
                            Id = 12,
                            SeatNumber = 12
                        },
                        new
                        {
                            Id = 13,
                            SeatNumber = 13
                        },
                        new
                        {
                            Id = 14,
                            SeatNumber = 14
                        },
                        new
                        {
                            Id = 15,
                            SeatNumber = 15
                        });
                });

            modelBuilder.Entity("BiografProjekt.Repo.DTO.Theater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfHalls")
                        .HasColumnType("int");

                    b.Property<int>("ParkingSpots")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Theater");
                });

            modelBuilder.Entity("BiografProjekt.Repo.DTO.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("BiografProjekt.Repo.DTO.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("PostNr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "streetname 1",
                            City = "there",
                            Email = "email123@mail.com",
                            IsAdmin = true,
                            Name = "Name",
                            Password = "Passw0rd",
                            Phone = 12344321,
                            PostNr = 1999
                        },
                        new
                        {
                            Id = 2,
                            Address = "itried 3",
                            City = "heree",
                            Email = "thisisamail@mail.com",
                            IsAdmin = false,
                            Name = "Alsoname",
                            Password = "Passw0rd",
                            Phone = 43211234,
                            PostNr = 1888
                        });
                });

            modelBuilder.Entity("BiografProjekt.Repo.DTO.Hall", b =>
                {
                    b.HasOne("BiografProjekt.Repo.DTO.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("BiografProjekt.Repo.DTO.Movie", b =>
                {
                    b.HasOne("BiografProjekt.Repo.DTO.Genre", "Genre")
                        .WithOne("movie")
                        .HasForeignKey("BiografProjekt.Repo.DTO.Movie", "GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BiografProjekt.Repo.DTO.Genre", b =>
                {
                    b.Navigation("movie")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
