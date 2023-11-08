using BiografProjekt.Repo.DTO;
using BiografProjekt.Repo.Interfaces;
using BiografProjekt.Repo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BiografProjekt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        IMovie movieRepo {  get; set; }
        public MovieController(IMovie movie)
        {
            this.movieRepo = movie;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                var movies = await movieRepo.getAll();
                if (movies == null)
                {
                    // something has gone wrong serverside, return code 500
                    return Problem("Unexpected null returned from service");
                }
                else if (movies.Count == 0)
                {
                    // no data exists, but still ok, return code 204
                    return NoContent();
                }
                // we got data! return with code 200
                return Ok(movies);
            }
            catch (Exception ex)
            {
                // handle any other exeptions raised by sending code 500
                return Problem(ex.Message);
            }
        }

        // GET: api/SuperHeroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetById(int id)
        {
            return await movieRepo.getById(id);
        }

        // PUT: api/SuperHeroes/5
        [HttpPut("{id}")]
        public async Task<Movie> UpdateMovie(Movie movie)
        {
            return await movieRepo.update(movie);
        }

        // POST: api/SuperHeroes
        [HttpPost]
        public async Task<ActionResult<Movie>> CreateMovie(Movie movie)
        {
            return await movieRepo.create(movie);
        }

        // DELETE: api/SuperHeroes/5
        [HttpDelete("{id}")]
        public async Task<Movie> DeleteMovie(int id)
        {
            return await movieRepo.delete(id);
        }
    }
}
