using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografProjekt.Repo.DTO
{
    public class Ticket
    {
        public int Id { get; set; }
        public int Price { get; set; }

        [ForeignKey("SeatId")]
        public int SeatId { get; set; }

        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
    }
}
