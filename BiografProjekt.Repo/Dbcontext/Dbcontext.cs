using BiografProjekt.Repo.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DbSet<Theater> Theater { get; set; }
    }





        
}
