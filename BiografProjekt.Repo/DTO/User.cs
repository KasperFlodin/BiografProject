namespace BiografProjekt.Repo.DTO
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PostNr { get; set; }
        public int Phone { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }
    }
}
