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
                var movies = await movieRepo.getAllInclude();
                //var movies = await movieRepo.getAllInclude();
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var movie = await movieRepo.getById(id);

                if (movie == null)
                {
                    return NotFound();
                }

                return Ok(movie);

            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }

        [HttpPut]
        //public async Task<Movie> UpdateMovie(Movie movie)
        public async Task<IActionResult> UpdateMovie(Movie movie)
        {
            //return await movieRepo.update(movie);
            try
            {
                var movieUpdate = await movieRepo.update(movie);

                if (movieUpdate == null)
                {
                    return NotFound();
                }

                return Ok(movieUpdate);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        //public async Task<ActionResult<Movie>> CreateMovie(Movie movie)
        public async Task<IActionResult> CreateMovie(Movie movie)
        {
            //return await movieRepo.create(movie);
            try
            {
                Movie createMovie = await movieRepo.create(movie);
                return Ok(createMovie); // Returns status 200 success
            }
            catch (Exception ex)
            {

                return Problem(ex.Message); // returnere error message
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            //return await movieRepo.delete(id);
            try
            {
                var deleteMovie = await movieRepo.delete(id);

                if (deleteMovie == null)
                {
                    return NotFound();
                }

                return Ok(deleteMovie);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
    }
}
