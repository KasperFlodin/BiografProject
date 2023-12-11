namespace BiografProjekt.Repo.DTO
{
    public class Seat
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public int Col { get; set; }
        public int Row { get; set; }
        public bool IsReserved { get; set; }

        [ForeignKey("HallId")]
        public int HallId { get; set; }
    }
}
