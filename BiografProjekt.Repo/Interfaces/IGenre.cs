using BiografProjekt.Repo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
