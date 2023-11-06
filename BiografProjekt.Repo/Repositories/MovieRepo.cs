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

        public async Task<Movie> getById(int id)
        {
            return await context.Movie.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Movie> create(Movie movie)
        {
            context.Movie.Add(movie);
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
