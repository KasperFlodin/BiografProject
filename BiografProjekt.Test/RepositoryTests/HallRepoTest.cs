namespace BiografProjekt.Test.ControllerTests
{
    public class HallRepoTest
    {
        private DbContextOptions<DatabaseContext> options;
        private DatabaseContext context;

        public HallRepoTest()
        {
            options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "Hall")
                .Options;

            context = new DatabaseContext(options);
            context.Database.EnsureDeleted();

            context.Hall.Add(new Hall { Id = 1, HallName = "Hall 1",/* MovieId = 2,*/ NumberOfSeats = 160, });
            context.Hall.Add(new Hall { Id = 2, HallName = "Hall 2", /*MovieId = 1,*/ NumberOfSeats = 120, });
            context.Hall.Add(new Hall { Id = 3, HallName = "Hall 3", /*MovieId = 5,*/ NumberOfSeats = 100, });
            context.Hall.Add(new Hall { Id = 4, HallName = "Hall 4", /*MovieId = 2,*/ NumberOfSeats = 100, });
            context.SaveChanges();
        }

        [Fact]
        public async Task GetHallsTest()
        {
            HallRepo hallRepository = new HallRepo(context);

            var hall = await hallRepository.getAll();

            Assert.Equal(4, hall.Count);
        }

        //[Fact]
        //public async Task GetHallsByMovieIdTest()
        //{
        //    HallRepo hallRepository = new HallRepo(context);

        //    var hall = await hallRepository.getById(2);

        //    Assert.Equal(2, hall.Count);
        //}

        [Fact]
        public async Task CreateHallTest()
        {
            HallRepo hallRepository = new HallRepo(context);

            Hall create = new Hall { Id = 5, HallName = "Hall E", /*MovieId = 2,*/ NumberOfSeats = 100 };

            await hallRepository.create(create);

            var hall = await hallRepository.getAll();

            Assert.Equal(5, hall.Count);
        }

        [Fact]
        public async Task DeleteHallTest()
        {
            HallRepo hallRepository = new HallRepo(context);

            var delete = await hallRepository.delete(1);

            var hall = await hallRepository.getAll();

            Assert.Equal(3, hall.Count);
        }


        [Fact]
        public async Task UpdateHallTest()
        {
            HallRepo hallRepository = new HallRepo(context);

            Hall update = new Hall { Id = 2, HallName = "Hall B", /*MovieId = 2,*/ NumberOfSeats = 100 };

            await hallRepository.update(update);

            var hall = await hallRepository.getById(2);

            Assert.Equal(2, hall.Id);
        }
    }
}
