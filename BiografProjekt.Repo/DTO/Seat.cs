using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografProjekt.Repo.DTO
{
    public class Seat
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }

        [ForeignKey("hallid")]
        int hallId { get; set; }
    }
}
