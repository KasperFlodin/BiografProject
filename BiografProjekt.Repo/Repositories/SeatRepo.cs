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
    public class SeatRepo : ISeat
    {
        DatabaseContext context;

        public SeatRepo(DatabaseContext temp)
        {
            context = temp;
        }

        public async Task<List<Seat>> getAll()
        {
            return await context.Seat.ToListAsync();
        }

        public async Task<Seat> getById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Seat> create(Seat seat)
        {
            throw new NotImplementedException();
        }

        public async Task<Seat> delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Seat> update(Seat updateSeat)
        {
            throw new NotImplementedException();
        }
    }
}
