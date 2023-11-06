using BiografProjekt.Repo.Dbcontext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografProjekt.Repo.Repositories
{
    public class MovieRepo 
    {
        DbContext context;

        public MovieRepo(DbContext temp)
        {
            context = temp
        }
    }
}
