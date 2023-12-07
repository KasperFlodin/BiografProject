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
            return await context.Seat.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Seat> create(Seat seat)
        {
            context.Seat.Add(seat);
            await context.SaveChangesAsync();

            return seat;
        }

        public async Task<Seat> delete(int id)
        {
            var seat = await context.Seat.FindAsync(id);

            if (seat != null)
            {
                context.Seat.Remove(seat);
                context.SaveChangesAsync();
            }
            return seat;
        }

        public async Task<Seat> update(Seat updateSeat)
        {
            var SeatUpdate = await context.Seat.FirstOrDefaultAsync(s => s.Id == updateSeat.Id);

            SeatUpdate.Id = updateSeat.Id;
            SeatUpdate.SeatNumber = updateSeat.SeatNumber;
            SeatUpdate.HallId = updateSeat.HallId;

            await context.SaveChangesAsync();
            return SeatUpdate;
        }
    }
}
