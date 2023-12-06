namespace BiografProjekt.Test.ControllerTests
{
    public class MovieRepoTest
    {
        private DbContextOptions<DatabaseContext> options;
        private DatabaseContext context;

        public MovieRepoTest()
        {
            options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "Movie")
                .Options;

            context = new DatabaseContext(options);
            context.Database.EnsureDeleted();

            context.Movie.Add(new Movie { Id = 1, Name = "DeadPool", ReleaseDate=2019, length=120, Poster = "https://i.pinimg.com/736x/e7/fd/e2/e7fde21159305bef134b9529bc46886e.jpg" });
            context.Movie.Add(new Movie { Id = 2, Name = "second", ReleaseDate=2012, length=130, Poster = "https://i.pinimg.com/736x/e7/fd/e2/e7fde21159305bef134b9529bc46886e.jpg" });
            context.Movie.Add(new Movie { Id = 3, Name = "third", ReleaseDate=2014, length=150, Poster = "https://i.pinimg.com/736x/e7/fd/e2/e7fde21159305bef134b9529bc46886e.jpg" });
            context.Movie.Add(new Movie { Id = 4, Name = "fourth", ReleaseDate=2008, length=110, Poster = "https://i.pinimg.com/736x/e7/fd/e2/e7fde21159305bef134b9529bc46886e.jpg" });
            
            context.SaveChanges();
        }

        [Fact]
        public async Task GetAllMoviesTest()
        {
            MovieRepo movieRepository = new MovieRepo(context);

            var movie = await movieRepository.getAll();

            Assert.Equal(4, movie.Count);
        }

        [Fact]
        public async Task getMovieByIdTest()
        {
            MovieRepo movieRepository = new MovieRepo(context);

            var movie = await movieRepository.getById(1);

            Assert.NotNull(movie);
            Assert.Equal("DeadPool", movie.Name);
        }

        [Fact]
        public async Task CreateMovieTest()
        {
            MovieRepo movieRepository = new MovieRepo(context);

            Movie create = new Movie { Id = 5, Name = "DeadPool1", ReleaseDate = 2020, length = 121, Poster = "https://i.pinimg.com/736x/e7/fd/e2/e7fde21159305bef134b9529bc46886e.jpg" };

            await movieRepository.create(create);

            var movie = await movieRepository.getAll();

            Assert.Equal(5, movie.Count);
        }

        [Fact]
        public async Task DeleteMovieTest()
        {
            MovieRepo movieRepository = new MovieRepo(context);

            var delete = await movieRepository.delete(1);

            var movie = await movieRepository.getAll();

            Assert.Equal(3, movie.Count);
        }

        [Fact]
        public async Task UpdateMovieTest()
        {
            MovieRepo movieRepository = new MovieRepo(context);

            Movie update = new Movie { Id = 1, Name = "DeadPool", ReleaseDate = 2019, length = 120, Poster = "https://i.pinimg.com/736x/e7/fd/e2/e7fde21159305bef134b9529bc46886e.jpg" };

            await movieRepository.update(update);

            var movie = await movieRepository.getById(1);

            Assert.Equal(120, movie.length);
            Assert.Equal(2019, movie.ReleaseDate);
            Assert.Equal("DeadPool", movie.Name);
            Assert.Equal(1, movie.Id);
        }
    }
}
