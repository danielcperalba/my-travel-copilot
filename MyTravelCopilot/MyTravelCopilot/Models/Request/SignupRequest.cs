namespace MyTravelCopilot.Models.Request
{
    public class SignupRequest
    {
        public Guid UserId { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
