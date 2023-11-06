using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografProjekt.Repo.DTO
{
    public class Theater
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int ParkingSpots { get; set; }
        public int NumberOfHalls { get; set; }
        public int shopId { get; set; }
    }
}
