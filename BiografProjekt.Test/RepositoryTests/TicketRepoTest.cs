namespace BiografProjekt.Test.ControllerTests
{
    public class TicketRepoTest
    {
        private DbContextOptions<DatabaseContext> options;
        private DatabaseContext context;

        public TicketRepoTest()
        {
            options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "Seat")
                .Options;

            context = new DatabaseContext(options);
            context.Database.EnsureDeleted();

            context.Ticket.Add(new Ticket { Id = 1, Price=40, SeatId = 5, MovieId = 1});
            context.Ticket.Add(new Ticket { Id = 2, Price=45, SeatId = 6, MovieId = 2});
            context.Ticket.Add(new Ticket { Id = 3, Price=35, SeatId = 7, MovieId = 3});
            context.Ticket.Add(new Ticket { Id = 4, Price=50, SeatId = 8, MovieId = 4});
            
            context.SaveChanges();
        }

        [Fact]
        public async Task GetTickets()
        {
            TicketRepo ticketRepository = new TicketRepo(context);

            var ticket = await ticketRepository.getAll();

            Assert.Equal(4, ticket.Count);
        }

        [Fact]
        public async Task GetTicketByIdTest()
        {
            TicketRepo ticketRepository = new TicketRepo(context);

            var ticket = await ticketRepository.getById(1);

            Assert.NotNull(ticket);
            Assert.Equal(1, ticket.Id);
        }

        [Fact]
        public async Task CreateUserTest()
        {
            TicketRepo ticketRepository = new TicketRepo(context);

            Ticket create = new Ticket { Id=5, Price = 40, SeatId = 9, MovieId = 2 };

            await ticketRepository.create(create);

            var ticket = await ticketRepository.getAll();

            Assert.Equal(5, ticket.Count);
        }

        [Fact]
        public async Task DeleteTicketTest()
        {
            TicketRepo ticketRepository = new TicketRepo(context);

            var delete = await ticketRepository.delete(1);

            var ticket = await ticketRepository.getAll();

            Assert.Equal(3, ticket.Count);
        }

        [Fact]
        public async Task UpdateUserTest()
        {
            TicketRepo ticketRepository = new TicketRepo(context);

            Ticket update = new Ticket { Id = 1, Price = 40, SeatId = 4, MovieId = 2 };

            await ticketRepository.update(update);

            var ticket = await ticketRepository.getById(1);

            
            Assert.Equal(1, ticket.Id);
            Assert.Equal(4, ticket.SeatId);
            Assert.Equal(2, ticket.MovieId);
        }
    }
}
