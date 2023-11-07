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
    public class UserRepo : IUser
    {
        DatabaseContext context;

        public UserRepo(DatabaseContext temp)
        {
            context = temp;
        }

        public async Task<List<User>> getAll()
        {
            return await context.User.ToListAsync();
        }

        public async Task<User> getById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> create(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> update(User updateUser)
        {
            throw new NotImplementedException();
        }
    }
}
