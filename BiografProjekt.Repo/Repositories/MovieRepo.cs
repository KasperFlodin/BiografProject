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

        public async Task<Movie> create(Movie movie) // Create both?3
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
                result.Poster = movie.Poster;
                result.genres = genreSelected;
            };
            
            context.Movie.Add(result);
            await context.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> delete(int id)
        {
            var movie = await context.Movie.FindAsync(id);

            if (movie != null)
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
            MovieUpdate.Poster = updateMovie.Poster;

            await context.SaveChangesAsync();
            return MovieUpdate;
        }

        //public async Task<Movie> createMovieAndGenre(Movie movie)
        //{
        //    // gemme genre men ikke movie
        //    Movie temp = new Movie()
        //    {
        //        Id = movie.Id,
        //        Name = movie.Name,
        //        ReleaseDate = movie.ReleaseDate,
        //        length = movie.length,
        //    };
        //    List<Genre> genres = new List<Genre>();
        //    //I have to "read the movies from the database,because if we assign a "new"
        //    //     Movie then it will create a row in movie table.
        //    //     If we read movie objects from database and then "work on them" we have a pointer to those
        //    //     objects.
        //    var genresSelected = context.Genre.
        //        Where(m => movie.genres.Select(p => p.Id).ToArray().Contains(m.Id)).ToList();
        //    temp.genres.AddRange(genresSelected);
        //    context.Movie.Add(temp);

        //    await context.SaveChangesAsync();
        //    return new Movie();
        //}
    }
}
