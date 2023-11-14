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
            return await context.User.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> create(User user)
        {
            context.User.Add(user);
            await context.SaveChangesAsync();

            return user;
        }

        public async Task<User> delete(int id)
        {
            var user = await context.User.FindAsync(id);

            if (user == null)
            {
                context.User.Remove(user);
                context.SaveChangesAsync();
            }
            return user;
        }

        public async Task<User> update(User updateUser)
        {
            var UserUpdate = await context.User.FirstOrDefaultAsync(u => u.Id == updateUser.Id);

            UserUpdate.Id = updateUser.Id;
            UserUpdate.Name = updateUser.Name;
            UserUpdate.Email = updateUser.Email;
            UserUpdate.Address = updateUser.Address;
            UserUpdate.City = updateUser.City;
            UserUpdate.PostNr = updateUser.PostNr;
            UserUpdate.Phone = updateUser.Phone;
            UserUpdate.Password = updateUser.Password;
            /*UserUpdate.IsAdmin = updateUser.IsAdmin;*/ // giver nok problemer...
            

            await context.SaveChangesAsync();
            return UserUpdate;
        }
    }
}
