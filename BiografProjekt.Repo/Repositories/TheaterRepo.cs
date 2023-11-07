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
            return await context.Theater.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Theater> create(Theater theater)
        {
            context.Theater.Add(theater);
            await context.SaveChangesAsync();

            return theater;
        }

        public async Task<Theater> delete(int id)
        {
            var theater = await context.Theater.FindAsync(id);

            if (theater == null)
            {
                context.Theater.Remove(theater);
                context.SaveChangesAsync();
            }
            return theater;
        }

        public async Task<Theater> update(Theater updateTheater)
        {
            var TheaterUpdate = await context.Theater.FirstOrDefaultAsync(t => t.Id == updateTheater.Id);

            TheaterUpdate.Id = updateTheater.Id;
            TheaterUpdate.Name = updateTheater.Name;
            TheaterUpdate.Location = updateTheater.Location;
            TheaterUpdate.ParkingSpots = updateTheater.ParkingSpots;
            TheaterUpdate.NumberOfHalls = updateTheater.NumberOfHalls;

            await context.SaveChangesAsync();
            return TheaterUpdate;
        }
    }
}
