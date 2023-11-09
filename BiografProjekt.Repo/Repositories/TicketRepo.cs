﻿namespace BiografProjekt.Repo.Repositories
{
    public class TicketRepo : ITicket
    {
        DatabaseContext context;

        public TicketRepo(DatabaseContext temp)
        {
            context = temp;
        }

        public async Task<List<Ticket>> getAll()
        {
            return await context.Ticket.ToListAsync();
        }

        public async Task<Ticket> getById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Ticket> create(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public async Task<Ticket> delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Ticket> update(Ticket updateTicket)
        {
            throw new NotImplementedException();
        }
    }
}
