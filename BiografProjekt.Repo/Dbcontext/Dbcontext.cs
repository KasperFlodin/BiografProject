using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using static System.Net.WebRequestMethods;

namespace BiografProjekt.Repo.Dbcontext
{
    public class DatabaseContext : DbContext // EntityFramework Core opsætning
    {
        // a class has 2 things (methods and properties)
        public DatabaseContext(DbContextOptions<DatabaseContext> option) : base(option) { }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Hall> Hall { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //    modelBuilder.Entity<User>()
            //        .HasData(
            //        new User
            //        {
            //            Id = 1,
            //            Name = "Name",
            //            Email = "email123@mail.com",
            //            Address = "streetname 1",
            //            City = "there",
            //            PostNr = 1999,
            //            Phone = 12344321,
            //            //IsAdmin = true,
            //            Password = "Passw0rd"
            //        },
            //        new User
            //        {
            //            Id = 2,
            //            Name = "Alsoname",
            //            Email = "thisisamail@mail.com",
            //            Address = "itried 3",
            //            City = "heree",
            //            PostNr = 1888,
            //            Phone = 43211234,
            //            //IsAdmin = false,
            //            Password = "Passw0rd"
            //        });

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Fantasy",
                },
                new Genre
                {
                    Id = 2,
                    Name = "Action",
                },
                new Genre
                {
                    Id = 3,
                    Name = "Horror",
                },
                new Genre
                {
                    Id = 4,
                    Name = "Romance",
                },
                new Genre
                {
                    Id = 5,
                    Name = "Adventure",
                },
                new Genre
                {
                    Id = 6,
                    Name = "Phychological",
                },
                new Genre
                {
                    Id = 7,
                    Name = "sci fi",
                },
                new Genre
                {
                    Id = 8,
                    Name = "Comedy",
                },
                new Genre
                {
                    Id = 9,
                    Name = "Crime",
                }

            //modelBuilder.Entity<Movie>().HasData(
            //    new Movie
            //    {
            //        Id = 1,
            //        Name = "first",
            //        ReleaseDate = 2020,
            //        length = 140,
            //        Poster = "https://frameimages.sfo2.cdn.digitaloceanspaces.com/launchpad-uploads/5d38ab8a97f8866f8b813c19.jpeg",
            //        genres = {},
            //    }
            //        new Movie
            //        {
            //            Id = 2,
            //            Name = "second",
            //            ReleaseDate = 2020,
            //            length = 110,
            //        },
            //        new Movie
            //        {
            //            Id = 3,
            //            Name = "third",
            //            ReleaseDate = 2020,
            //            length = 120,
            //        },
            //    //    new Movie
            //    //    {
            //    //        Id = 4,
            //    //        Name = "fourth",
            //    //        ReleaseDate = 2024,
            //    //        length = 140,
            //    //        //GenreId= 4,
            //    //    },
            //    //    new Movie
            //    //    {
            //    //        Id = 5,
            //    //        Name = "fifth",
            //    //        ReleaseDate = 2020,
            //    //        length = 130,
            //    //        //GenreId= 5,
            //    //    },
            //    //    new Movie
            //    //    {
            //    //        Id = 6,
            //    //        Name = "sixth",
            //    //        ReleaseDate = 2020,
            //    //        length = 130,
            //    //        //GenreId= 6
            //    //    },
            //    //    new Movie
            //    //    {
            //    //        Id = 7,
            //    //        Name = "seventh",
            //    //        ReleaseDate = 2020,
            //    //        length = 180,
            //    //        //GenreId = 8
                /*}*/);

            //    modelBuilder.Entity<Seat>().HasData(
            //        new Seat
            //        {
            //            Id = 1,
            //            SeatNumber = 1,
            //        },
            //        new Seat
            //        {
            //            Id = 2,
            //            SeatNumber = 2,
            //        },
            //        new Seat
            //        {
            //            Id = 3,
            //            SeatNumber = 3,
            //        },
            //        new Seat
            //        {
            //            Id = 4,
            //            SeatNumber = 4,
            //        },
            //        new Seat
            //        {
            //            Id = 5,
            //            SeatNumber = 5,
            //        },
            //        new Seat
            //        {
            //            Id = 6,
            //            SeatNumber = 6,
            //        },
            //        new Seat
            //        {
            //            Id = 7,
            //            SeatNumber = 7,
            //        },
            //        new Seat
            //        {
            //            Id = 8,
            //            SeatNumber = 8,
            //        },
            //        new Seat
            //        {
            //            Id = 9,
            //            SeatNumber = 9,
            //        },
            //        new Seat
            //        {
            //            Id = 10,
            //            SeatNumber = 10,
            //        },
            //        new Seat
            //        {
            //            Id = 11,
            //            SeatNumber = 11,
            //        },
            //        new Seat
            //        {
            //            Id = 12,
            //            SeatNumber = 12,
            //        },
            //        new Seat
            //        {
            //            Id = 13,
            //            SeatNumber = 13,
            //        },
            //        new Seat
            //        {
            //            Id = 14,
            //            SeatNumber = 14,
            //        },
            //        new Seat
            //        {
            //            Id = 15,
            //            SeatNumber = 15,
            //        });

            //    modelBuilder.Entity<Hall>().HasData(
            //       new Hall
            //       {
            //           Id = 1,
            //           NumberOfSeats = 5,
            //           HallName = "Hall 1",
            //           MovieId = 1,
            //       },
            //       new Hall
            //       {
            //           Id = 2,
            //           NumberOfSeats = 5,
            //           HallName = "Hall 2",
            //           MovieId = 2,
            //       }
            //       , new Hall
            //       {
            //           Id = 3,
            //           NumberOfSeats = 5,
            //           HallName = "Hall 3",
            //           MovieId = 3,
            //       });


        }
    }

}
