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
            return await context.Hall.FirstOrDefaultAsync(h => h.Id == id);
        }

        public async Task<Hall> create(Hall hall)
        {
            context.Hall.Add(hall);
            await context.SaveChangesAsync();

            return hall;
        }

        public async Task<Hall> delete(int id)
        {
            var hall = await context.Hall.FindAsync(id);

            if (hall == null)
            {
                context.Hall.Remove(hall);
                context.SaveChangesAsync();
            }
            return hall;
        }

        public async Task<Hall> update(Hall updateHall)
        {
            var HallUpdate = await context.Hall.FirstOrDefaultAsync(h => h.Id == updateHall.Id);

            HallUpdate.Id = updateHall.Id;
            HallUpdate.NumberOfSeats = updateHall.NumberOfSeats;
            

            await context.SaveChangesAsync();
            return HallUpdate;
        }
    }
}
