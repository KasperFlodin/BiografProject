namespace BiografProjekt.Repo.Interfaces
{
    public interface IGenre
    {
        public Task<List<Genre>> getAll();

        public Task<Genre> getById(int id);

        public Task<Genre> create(Genre genre);

        public Task<Genre> update(Genre updateGenre);

        public Task<Genre> delete(int id);
    }
}
