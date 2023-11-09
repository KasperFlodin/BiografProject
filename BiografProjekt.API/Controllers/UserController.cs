using BiografProjekt.Repo.DTO;
using BiografProjekt.Repo.Interfaces;

namespace BiografProjekt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUser userRepo { get; set; }
        public UserController(IUser user)
        {
            this.userRepo = user;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                var users = await userRepo.getAll();
                if (users == null)
                {
                    // something has gone wrong serverside, return code 500
                    return Problem("Unexpected null returned from service");
                }
                else if (users.Count == 0)
                {
                    // no data exists, but still ok, return code 204
                    return NoContent();
                }
                // we got data! return with code 200
                return Ok(users);
            }
            catch (Exception ex)
            {
                // handle any other exeptions raised by sending code 500
                return Problem(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var user = await userRepo.getById(id);

                if (user == null)
                {
                    return NotFound();
                }

                return Ok(user);

            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }

        [HttpPut]
        //public async Task<Movie> UpdateMovie(Movie movie)
        public async Task<IActionResult> UpdateUser(User user)
        {
            //return await movieRepo.update(movie);
            try
            {
                var userUpdate = await userRepo.update(user);

                if (userUpdate == null)
                {
                    return NotFound();
                }

                return Ok(userUpdate);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        //public async Task<ActionResult<Movie>> CreateMovie(Movie movie)
        public async Task<IActionResult> CreateUser(User user)
        {
            //return await movieRepo.create(movie);
            try
            {
                User createUser = await userRepo.create(user);
                return Ok(createUser); // Returns status 200 success
            }
            catch (Exception ex)
            {

                return Problem(ex.Message); // returnere error message
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            //return await movieRepo.delete(id);
            try
            {
                var deleteUser = await userRepo.delete(id);

                if (deleteUser == null)
                {
                    return NotFound();
                }

                return Ok(deleteUser);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
    }
}
