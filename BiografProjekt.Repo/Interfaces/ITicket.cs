namespace BiografProjekt.Repo.Interfaces
{
    public interface ITicket
    {
        public Task<List<Ticket>> getAll();

        public Task<Ticket> getById(int id);

        public Task<Ticket> create(Ticket ticket);

        public Task<Ticket> update(Ticket updateTicket);

        public Task<Ticket> delete(int id);
    }
}
