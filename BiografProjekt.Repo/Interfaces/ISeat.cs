namespace BiografProjekt.Repo.Interfaces
{
    public interface ISeat
    {
        public Task<List<Seat>> getAll();

        public Task<Seat> getById(int id);

        public Task<List<Seat>> getByHallId(int id);

        //public Task<Seat> create(Seat seat);
        public Task<List<Seat>> create(int row, int col, int hallId);

        public Task<Seat> update(Seat updateSeat);

        public Task<Seat> delete(int id);
    }
}
