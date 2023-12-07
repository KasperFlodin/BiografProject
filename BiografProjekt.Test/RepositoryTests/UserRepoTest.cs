namespace BiografProjekt.Test.ControllerTests
{
    public class UserRepoTest
    {
        private DbContextOptions<DatabaseContext> options;
        private DatabaseContext context;

        public UserRepoTest()
        {
            options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "User")
                .Options;

            context = new DatabaseContext(options);
            context.Database.EnsureDeleted();

            context.User.Add(new User { Id=1, Name = "Bow", Email = "Bow@gmail.com", Address="Somewhere 32", City="Nowhere", PostNr=2000, Phone=12345678, Role=Role.Admin, Password="Passw0rd" });
            context.User.Add(new User { Id=2, Name = "Boy", Email = "Boy@gmail.com", Address="Somewhere1 32", City="Nowhere1", PostNr=2001, Phone=11223344, Role=Role.User, Password="Passw0rd" });
            context.User.Add(new User { Id=3, Name = "Bored", Email = "Bored@gmail.com", Address="Somewhere2 32", City="Nowhere2", PostNr=2002, Phone=12341234, Role=Role.User, Password="Passw0rd" });
            context.User.Add(new User { Id=4, Name = "Ko", Email = "Ko@gmail.com", Address="Somewhere3 32", City="Nowhere3", PostNr=2003, Phone=87654321, Role=Role.User, Password="Passw0rd" });
            context.SaveChanges();
        }

        [Fact]
        public async Task GetUsersTest()
        {
            UserRepo userRepository = new UserRepo(context);

            var user = await userRepository.getAll();

            Assert.Equal(4, user.Count);
        }

        [Fact]
        public async Task GetUserByNameTest()
        {
            UserRepo userRepository = new UserRepo(context);

            var user = await userRepository.getByName("Jane");

            Assert.NotNull(user);
            Assert.Equal("Jane", user.Name);
        }
        
        [Fact]
        public async Task GetUserByEmailTest()
        {
            UserRepo userRepository = new UserRepo(context);

            var user = await userRepository.getByEmail("Bow@Gmail.com");

            Assert.NotNull(user);
            Assert.Equal("Bow@Gmail.com", user.Email);
        }
    }
}
