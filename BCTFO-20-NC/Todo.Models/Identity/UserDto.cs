namespace Todo.Models.Identity
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int ActivationCount { get; set; }
        public bool LockoutEnabled { get; set; }
    }
}
