using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BiografProjekt.Repo.DTO
{
    public class Hall
    {
        public int Id { get; set; }
        public int NumberOfSeats { get; set; }

        [JsonIgnore]
        [ForeignKey("Genre.Id")]
        public int MovieId { get; set; }
    }
}
