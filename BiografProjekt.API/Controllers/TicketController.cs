using BiografProjekt.Repo.DTO;
using BiografProjekt.Repo.Interfaces;
using System.Net.Sockets;

namespace BiografProjekt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        ITicket ticketRepo { get; set; }
        public TicketController(ITicket ticket)
        {
            this.ticketRepo = ticket;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                var tickets = await ticketRepo.getAll();
                if (tickets == null)
                {
                    // something has gone wrong serverside, return code 500
                    return Problem("Unexpected null returned from service");
                }
                else if (tickets.Count == 0)
                {
                    // no data exists, but still ok, return code 204
                    return NoContent();
                }
                // we got data! return with code 200
                return Ok(tickets);
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
                var ticket = await ticketRepo.getById(id);

                if (ticket == null)
                {
                    return NotFound();
                }

                return Ok(ticket);

            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }

        [HttpPut]
        //public async Task<Movie> UpdateMovie(Movie movie)
        public async Task<IActionResult> UpdateTicket(Ticket ticket)
        {
            //return await movieRepo.update(movie);
            try
            {
                var ticketUpdate = await ticketRepo.update(ticket);

                if (ticketUpdate == null)
                {
                    return NotFound();
                }

                return Ok(ticketUpdate);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        //public async Task<ActionResult<Movie>> CreateMovie(Movie movie)
        public async Task<IActionResult> CreateTicket(Ticket ticket)
        {
            //return await movieRepo.create(movie);
            try
            {
                Ticket createTicket = await ticketRepo.create(ticket);
                return Ok(createTicket); // Returns status 200 success
            }
            catch (Exception ex)
            {

                return Problem(ex.Message); // returnere error message
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            //return await movieRepo.delete(id);
            try
            {
                var deleteTicket = await ticketRepo.delete(id);

                if (deleteTicket == null)
                {
                    return NotFound();
                }

                return Ok(deleteTicket);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
    }
}
