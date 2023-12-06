namespace BiografProjekt.Test.ControllerTests
{
    public class GenreRepoTest
    {
        private DbContextOptions<DatabaseContext> options;
        private DatabaseContext context;

        public GenreRepoTest()
        {
            options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "GenreStore")
                .Options;

            context = new DatabaseContext(options);
            context.Database.EnsureDeleted();

            context.Genre.Add(new Genre { Id = 1, Name = "Fantasy" });
            context.Genre.Add(new Genre { Id = 2, Name = "Action" });
            context.Genre.Add(new Genre { Id = 3, Name = "Horror" });
            context.Genre.Add(new Genre { Id = 4, Name = "Romance" });
            context.Genre.Add(new Genre { Id = 5, Name = "Adventure" });
            context.Genre.Add(new Genre { Id = 6, Name = "Comedy" });
            context.SaveChanges();
        }

        [Fact]
        public async Task GetGenresTest()
        {
            GenreRepo genreRepository = new GenreRepo(context);

            var genre = await genreRepository.getAll();

            Assert.Equal(6, genre.Count);
        }

        [Fact]
        public async Task GetGenreByNameTest()
        {
            GenreRepo genreRepository = new GenreRepo(context);

            var genre = await genreRepository.getById(4);

            Assert.NotNull(genre);
            Assert.Equal(4, genre.Id);
        }

        [Fact]
        public async Task CreateGenreTest()
        {
            GenreRepo genreRepository = new GenreRepo(context);

            Genre create = new Genre { Id = 7, Name = "SciFi" };

            await genreRepository.create(create);

            var genre = await genreRepository.getAll();

            Assert.Equal(7, genre.Count);
        }

        [Fact]
        public async Task DeleteGenreTest()
        {
            GenreRepo genreRepository = new GenreRepo(context);

            var delete = await genreRepository.delete(5);

            var genre = await genreRepository.getAll();

            Assert.Equal(5, genre.Count);
        }

        [Fact]
        public async Task UpdateGenreTest()
        {
            GenreRepo genreRepository = new GenreRepo(context);

            Genre update = new Genre { Id = 2 ,Name = "Action", };

            await genreRepository.update(update);

            var genre = await genreRepository.getById(2);

            Assert.Equal("Action", genre.Name);
            Assert.Equal(2, genre.Id);
        }
    }
}
