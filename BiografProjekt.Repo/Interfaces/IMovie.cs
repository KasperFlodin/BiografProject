namespace BiografProjekt.Repo.Interfaces
{
    public interface IMovie
    {
        public Task<List<Movie>> getAll();
        public Task<List<Movie>> getAllInclude();

        public Task<Movie> getById(int id);

        public Task<Movie> create(Movie movie);

        public Task<Movie> update(Movie updateMovie);

        public Task<Movie> delete(int id);
        //public Task<Movie> createMovieAndGenre(Movie movie);
    }
}
