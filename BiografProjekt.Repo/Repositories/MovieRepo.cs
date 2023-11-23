using BiografProjekt.Repo.DTO;

namespace BiografProjekt.Repo.Repositories
{
    public class MovieRepo : IMovie
    {
        //Dbcontext context;
        DatabaseContext context;

        public MovieRepo(DatabaseContext temp)
        {
            context = temp;
        }

        public async Task<List<Movie>> getAll()
        {
            return await context.Movie.ToListAsync();
        }

        public async Task<List<Movie>> getAllInclude()
        {
            return await context.Movie.Include(g => g.genres).ToListAsync();
        }

        public async Task<Movie> getById(int id)
        {
            return await context.Movie.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Movie> create(Movie movie) // Create both?
        {
            if (movie == null) { return null; }

            List<Genre> genreSelected = context.Genre.
            Where(obj => movie.genres.Select(p => p.Id).ToArray().Contains(obj.Id))
           .ToList();

            Movie result = new Movie();
            {
                result.Id = movie.Id;
                result.Name = movie.Name;
                result.length = movie.length;
                result.ReleaseDate = movie.ReleaseDate;
                result.genres = genreSelected;
            };
            
            context.Movie.Add(result);
            await context.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> delete(int id)
        {
            var movie = await context.Movie.FindAsync(id);

            if (movie == null)
            {
                context.Movie.Remove(movie);
                context.SaveChangesAsync();
            }
            return movie;
        }

        public async Task<Movie> update(Movie updateMovie)
        {
            var MovieUpdate = await context.Movie.FirstOrDefaultAsync(m => m.Id == updateMovie.Id);

            MovieUpdate.Id = updateMovie.Id;
            MovieUpdate.Name = updateMovie.Name;
            MovieUpdate.ReleaseDate = updateMovie.ReleaseDate;
            MovieUpdate.length = updateMovie.length;

            await context.SaveChangesAsync();
            return MovieUpdate;
        }
    }
}
