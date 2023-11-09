using BiografProjekt.Repo.Repositories;

namespace BiografProjekt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        IGenre genreRepo { get; set; }
        public GenreController(IGenre genre)
        {
            this.genreRepo = genre;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                var genres = await genreRepo.getAll();
                if (genres == null)
                {
                    // something has gone wrong serverside, return code 500
                    return Problem("Unexpected null returned from service");
                }
                else if (genres.Count == 0)
                {
                    // no data exists, but still ok, return code 204
                    return NoContent();
                }
                // we got data! return with code 200
                return Ok(genres);
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
                var genre = await genreRepo.getById(id);

                if (genre == null)
                {
                    return NotFound();
                }

                return Ok(genre);

            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }

        [HttpPost]
        //public async Task<ActionResult<Movie>> CreateMovie(Movie movie)
        public async Task<IActionResult> CreateGenre(Genre genre)
        {
            //return await movieRepo.create(movie);
            try
            {
                Genre createGenre = await genreRepo.create(genre);
                return Ok(createGenre); // Returns status 200 success
            }
            catch (Exception ex)
            {

                return Problem(ex.Message); // returnere error message
            }
        }

        [HttpPut]
        //public async Task<Movie> UpdateMovie(Movie movie)
        public async Task<IActionResult> UpdateGenre(Genre genre)
        {
            //return await movieRepo.update(movie);
            try
            {
                var genreUpdate = await genreRepo.update(genre);

                if (genreUpdate == null)
                {
                    return NotFound();
                }

                return Ok(genreUpdate);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            //return await movieRepo.delete(id);
            try
            {
                var deleteGenre = await genreRepo.delete(id);

                if (deleteGenre == null)
                {
                    return NotFound();
                }

                return Ok(deleteGenre);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
    }
}
