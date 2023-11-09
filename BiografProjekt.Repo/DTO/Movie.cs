namespace BiografProjekt.Repo.DTO
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseDate { get; set; }
        public int length { get; set; }

        [JsonIgnore]
        [ForeignKey("Genre.Id")]
        public int GenreId { get; set; }
        [JsonIgnore]
        public Genre Genre { get; set; }
    }
}
