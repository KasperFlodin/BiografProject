using BiografProjekt.Repo.DTO;

namespace BiografProjekt.Repo.Repositories
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
            return await context.Ticket.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Ticket> create(Ticket ticket)
        {
            context.Ticket.Add(ticket);
            await context.SaveChangesAsync();

            return ticket; ;
        }

        public async Task<Ticket> delete(int id)
        {
            var ticket = await context.Ticket.FindAsync(id);

            if (ticket != null)
            {
                context.Ticket.Remove(ticket);
                context.SaveChangesAsync();
            }
            return ticket;
        }

        public async Task<Ticket> update(Ticket updateTicket)
        {
            var ticketUpdate = await context.Ticket.FirstOrDefaultAsync(g => g.Id == updateTicket.Id);

            ticketUpdate.Id = updateTicket.Id;
            ticketUpdate.Price = updateTicket.Price;
            ticketUpdate.SeatId = updateTicket.SeatId;
            ticketUpdate.MovieId = updateTicket.MovieId;

            await context.SaveChangesAsync();
            return ticketUpdate;
        }
    }
}
