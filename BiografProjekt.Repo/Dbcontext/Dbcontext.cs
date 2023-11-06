using BiografProjekt.Repo.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografProjekt.Repo.Dbcontext
{
    public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions<Dbcontext> option) : base(option) 
        {
            
        }

        public DbSet<Movie> movie { get; set; }
    }
}
