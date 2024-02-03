using Flunt.Validations;
using MyTravelCopilot.Models.Request;

namespace MyTravelCopilot.Contracts
{
    public class LoginContract : Contract<LoginRequest>
    {
        public LoginContract(LoginRequest request)
        {
            Requires()
                .IsNotNullOrEmpty(request.Email, "Email", "Email cannot be null")
                .IsEmail(request.Email, "Email", "Invalid email")
                .IsNullOrEmpty(request.Password, "Password", "Password cannot be null");
        }
    }
}
