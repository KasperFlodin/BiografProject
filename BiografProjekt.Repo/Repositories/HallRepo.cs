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
    public class HallRepo : IHall
    {
        DatabaseContext context;

        public HallRepo(DatabaseContext temp)
        {
            context = temp;
        }

        public async Task<List<Hall>> getAll()
        {
            return await context.Hall.ToListAsync();
        }

        public async Task<Hall> getById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Hall> create(Hall hall)
        {
            throw new NotImplementedException();
        }

        public async Task<Hall> delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Hall> update(Hall updateHall)
        {
            throw new NotImplementedException();
        }
    }
}
