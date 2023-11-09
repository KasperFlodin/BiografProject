namespace BiografProjekt.Repo.DTO
{
    public class Hall
    {
        public int Id { get; set; }
        public int NumberOfSeats { get; set; }

        [JsonIgnore]
        [ForeignKey("Movie.Id")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        //[JsonIgnore]
        //[ForeignKey("Seat.Id")]
        //public int SeatId { get; set; }
        //public Seat Seat { get; set; }
    }
}
