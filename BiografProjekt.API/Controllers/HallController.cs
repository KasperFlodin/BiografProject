using BiografProjekt.Repo.Interfaces;

namespace BiografProjekt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HallController : ControllerBase
    {
        IHall hallRepo { get; set; }
        public HallController(IHall hall)
        {
            this.hallRepo = hall;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                var halls = await hallRepo.getAll();
                //var halls = await hallRepo.getAllIncludeMovie();
                if (halls == null)
                {
                    // something has gone wrong serverside, return code 500
                    return Problem("Unexpected null returned from service");
                }
                else if (halls.Count == 0)
                {
                    // no data exists, but still ok, return code 204
                    return NoContent();
                }
                // we got data! return with code 200
                return Ok(halls);
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
                var hall = await hallRepo.getById(id);

                if (hall == null)
                {
                    return NotFound();
                }

                return Ok(hall);

            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }

        [HttpPost]
        //public async Task<ActionResult<Movie>> CreateMovie(Movie movie)
        public async Task<IActionResult> CreateGenre(Hall hall)
        {
            //return await movieRepo.create(movie);
            try
            {
                Hall createHall = await hallRepo.create(hall);
                return Ok(createHall); // Returns status 200 success
            }
            catch (Exception ex)
            {

                return Problem(ex.Message); // returnere error message
            }
        }

        [HttpPut]
        //public async Task<Movie> UpdateMovie(Movie movie)
        public async Task<IActionResult> UpdateHall(Hall hall)
        {
            //return await movieRepo.update(movie);
            try
            {
                var hallUpdate = await hallRepo.update(hall);

                if (hallUpdate == null)
                {
                    return NotFound();
                }

                return Ok(hallUpdate);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteHall(int id)
        {
            //return await movieRepo.delete(id);
            try
            {
                var deleteHall = await hallRepo.delete(id);

                if (deleteHall == null)
                {
                    return NotFound();
                }

                return Ok(deleteHall);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
    }
}
