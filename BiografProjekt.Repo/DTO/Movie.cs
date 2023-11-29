namespace BiografProjekt.Repo.DTO
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseDate { get; set; }
        public int length { get; set; }
        public string Poster { get; set; }

        //[JsonIgnore]
        //[ForeignKey("Genre.Id")]
        //public int GenreId { get; set; }
        //[JsonIgnore]
        public List<Genre> genres { get; set; } = new List<Genre>();
    }
}



//https://frameimages.sfo2.cdn.digitaloceanspaces.com/launchpad-uploads/5d38ab8a97f8866f8b813c19.jpeg
