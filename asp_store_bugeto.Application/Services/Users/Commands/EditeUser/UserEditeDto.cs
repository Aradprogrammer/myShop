namespace asp_store_bugeto.Application.Services.Users.Commands.EditeUser
{
    public class UserEditeDto
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
}
