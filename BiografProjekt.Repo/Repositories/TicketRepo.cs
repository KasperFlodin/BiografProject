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
            throw new NotImplementedException();
        }

        public async Task<Ticket> update(Ticket updateTicket)
        {
            throw new NotImplementedException();
        }
    }
}
