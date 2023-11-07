using BiografProjekt.Repo.Dbcontext;
using BiografProjekt.Repo.DTO;
using BiografProjekt.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografProjekt.Repo.Repositories
{
    public class GenreRepo : IGenre
    {
        DatabaseContext context;

        public GenreRepo(DatabaseContext temp)
        {
            context = temp;
        }

        public async Task<List<Genre>> getAll()
        {
            return await context.Genre.ToListAsync();
        }

        public async Task<Genre> getById(int id)
        {
            return await context.Genre.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Genre> create(Genre genre)
        {
            context.Genre.Add(genre);
            await context.SaveChangesAsync();

            return genre;
        }

        public async Task<Genre> delete(int id)
        {
            var genre = await context.Genre.FindAsync(id);

            if (genre == null)
            {
                context.Genre.Remove(genre);
                context.SaveChangesAsync();
            }
            return genre;
        }

        public async Task<Genre> update(Genre updateGenre)
        {
            var genreUpdate = await context.Genre.FirstOrDefaultAsync(m => m.Id == updateGenre.Id);

            genreUpdate.Id = updateGenre.Id;
            genreUpdate.Name = updateGenre.Name;

            await context.SaveChangesAsync();
            return genreUpdate;
        }
    }
}
