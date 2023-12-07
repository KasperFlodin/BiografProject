namespace BiografProjekt.Repo.DTO
{
    public class Seat
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }

        [JsonIgnore]
        [ForeignKey("hallid")]
        public int HallId { get; set; }
    }
}
