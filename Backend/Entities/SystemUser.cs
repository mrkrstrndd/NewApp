namespace Backend.Entities
{
    public class SystemUser
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
