using BiografProjekt.Repo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografProjekt.Repo.Interfaces
{
    public interface IMovie
    {
        public Task<List<Movie>> getAll();
        // SuperHero getByName(string name);

        public Task<Movie> getById(int id);

        public Task<Movie> create(Movie movie);

        public Task<Movie> update(Movie updateMovie);

        public Task<Movie> delete(int id);
    }
}
