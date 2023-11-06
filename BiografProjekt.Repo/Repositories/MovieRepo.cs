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
        Dbcontext context;

        public MovieRepo(Dbcontext temp)
        {
            context = temp;
        }

        public async Task<List<Movie>> getAll()
        {
            return await context.Movie.ToListAsync();
        }

        public async Task<Movie> getById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> create(Movie movie)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> update(Movie updateMovie)
        {
            throw new NotImplementedException();
        }
    }
}
