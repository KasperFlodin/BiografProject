namespace BiografProjekt.Test.ControllerTests
{
    public class SeatRepoTest
    {
        private DbContextOptions<DatabaseContext> options;
        private DatabaseContext context;

        public SeatRepoTest()
        {
            options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "Seat")
                .Options;

            context = new DatabaseContext(options);
            context.Database.EnsureDeleted();

            context.Seat.Add(new Seat { Id = 1, SeatNumber = 5, HallId = 1 });
            context.Seat.Add(new Seat { Id = 2, SeatNumber = 5, HallId = 2 });
            context.Seat.Add(new Seat { Id = 3, SeatNumber = 5, HallId = 3 });
            context.Seat.Add(new Seat { Id = 4, SeatNumber = 5, HallId = 4 });
            context.SaveChanges();
        }

        [Fact]
        public async Task GetSeats()
        {
            SeatRepo seatRepository = new SeatRepo(context);

            var seat = await seatRepository.getAll();

            Assert.Equal(4, seat.Count);
        }

        [Fact]
        public async Task CreateUserTest()
        {
            SeatRepo seatRepository = new SeatRepo(context);

            Seat create = new Seat { Id = 5, HallId = 1, SeatNumber = 5 };

            await seatRepository.create(create);

            var seat = await seatRepository.getAll();

            Assert.Equal(5, seat.Count);
        }

        [Fact]
        public async Task DeleteSeatTest()
        {
            SeatRepo seatRepository = new SeatRepo(context);

            var delete = await seatRepository.delete(1);

            var seat = await seatRepository.getAll();

            Assert.Equal(3, seat.Count);
        }

        [Fact]
        public async Task UpdateUserTest()
        {
            SeatRepo seatRepository = new SeatRepo(context);

            Seat update = new Seat { Id = 1, HallId = 3, SeatNumber = 5 };

            await seatRepository.update(update);

            var seat = await seatRepository.getById(1);

            Assert.Equal(1, seat.Id);
            Assert.Equal(3, seat.HallId);
            Assert.Equal(5, seat.SeatNumber);
        }
    }
}
