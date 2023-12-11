using BiografProjekt.Repo.DTO;
using BiografProjekt.Repo.Interfaces;

namespace BiografProjekt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        ISeat seatRepo { get; set; }
        public SeatController(ISeat seat)
        {
            this.seatRepo = seat;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                var seats = await seatRepo.getAll();
                if (seats == null)
                {
                    // something has gone wrong serverside, return code 500
                    return Problem("Unexpected null returned from service");
                }
                else if (seats.Count == 0)
                {
                    // no data exists, but still ok, return code 204
                    return NoContent();
                }
                // we got data! return with code 200
                return Ok(seats);
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
                var seat = await seatRepo.getById(id);

                if (seat == null)
                {
                    return NotFound();
                }

                return Ok(seat);

            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }

        [HttpGet("HallId{HallId}")]
        public async Task<IActionResult> GetByHallId(int HallId)
        {
            try
            {
                var hallSeat = await seatRepo.getByHallId(HallId);

                if (hallSeat == null)
                {
                    return NotFound();
                }

                return Ok(hallSeat);

            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }

        [HttpPut]
        //public async Task<Movie> UpdateMovie(Movie movie)
        public async Task<IActionResult> UpdateSeat(Seat seat)
        {
            //return await movieRepo.update(movie);
            try
            {
                var seatUpdate = await seatRepo.update(seat);

                if (seatUpdate == null)
                {
                    return NotFound();
                }

                return Ok(seatUpdate);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        //public async Task<ActionResult<Movie>> CreateMovie(Movie movie)
        public async Task<IActionResult> CreateSeat(int row, int col, int hallId)
        {
            try
            {
                List<Seat> seatMovie = await seatRepo.create(row, col, hallId);
                return Ok(seatMovie); // Returns status 200 success
            }
            catch (Exception ex)
            {
                return Problem(ex.Message); // returnere error message
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSeat(int id)
        {
            //return await movieRepo.delete(id);
            try
            {
                var deleteSeat = await seatRepo.delete(id);

                if (deleteSeat == null)
                {
                    return NotFound();
                }

                return Ok(deleteSeat);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
    }
}
