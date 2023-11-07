using BiografProjekt.Repo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografProjekt.Repo.Interfaces
{
    public interface IUser
    {
        public Task<List<User>> getAll();

        public Task<User> getById(int id);

        public Task<User> create(User user);

        public Task<User> update(User updateUser);

        public Task<User> delete(int id);
    }
}
