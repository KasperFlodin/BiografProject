using BiografProjekt.Repo.Dbcontext;
using BiografProjekt.Repo.DTO;
using BiografProjekt.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografProjekt.Repo.Repositories
{
    public class TheaterRepo : ITheater
    {
        DatabaseContext context;

        public TheaterRepo(DatabaseContext temp)
        {
            context = temp;
        }

        public async Task<List<Theater>> getAll()
        {
            return await context.Theater.ToListAsync();
        }

        public async Task<Theater> getById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Theater> create(Theater theater)
        {
            throw new NotImplementedException();
        }

        public async Task<Theater> delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Theater> update(Theater updateTheater)
        {
            throw new NotImplementedException();
        }
    }
}
