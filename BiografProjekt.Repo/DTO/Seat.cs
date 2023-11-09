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
