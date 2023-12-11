namespace BiografProjekt.Repo.DTO
{
    public class Hall
    {
        public int Id { get; set; }
        public int NumberOfSeats { get; set; }
        public string HallName { get; set; }

        //[JsonIgnore]
        public List<Seat> Seats { get; set; }

        //[JsonIgnore]
        //[ForeignKey("Movie.Id")]
        //public int MovieId { get; set; }

        //[JsonIgnore]
        //public Movie Movie { get; set; }

        //[JsonIgnore]
        //[ForeignKey("Seat.Id")]
        //public int SeatId { get; set; }
        //public Seat Seat { get; set; }
    }
}
