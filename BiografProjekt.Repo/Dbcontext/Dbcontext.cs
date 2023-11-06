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
    }





        
}
