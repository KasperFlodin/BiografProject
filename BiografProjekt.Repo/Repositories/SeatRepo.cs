using Microsoft.Data.Sql;

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
        
        public async Task<Seat> getByHallId(int id)
        {
            return await context.Seat.FirstOrDefaultAsync(s => s.HallId == id);
        }

        public async Task<List<Seat>> create(int row, int col, int hallId)
        {
            // UseCase generer antal row og coloner til at lave en Hall, skal udføres som et multidimesionelt 
            // Array, forlykke struktur til at save alle i list på en gang
            // 1 forlykke til row / 1 forlykke til col
            // 2 forlykker for at løbe både row og col igennem da de er multidemensionel
            // så vi skal indtaste row og colomn i swagger 

            List<Seat> seats = new List<Seat>();
            int seatnumberTemp = 1;
            for (int i = 1; i <= col; i++)
            {
                
                for(int r = 1; r <= row; r++)
                {
                    
                    seats.Add(new Seat { Id=0, SeatNumber=seatnumberTemp++, Col=i, Row=r, IsReserved=false, HallId=hallId});
                    context.Seat.AddRange(seats);
                }
            }

            await context.SaveChangesAsync();

            return seats;
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
