using MyTravelCopilot.Models.Request;
using Flunt.Validations;

namespace MyTravelCopilot.Contracts
{
    public class SignupContract : Contract<SignupRequest>
    {
        public SignupContract(SignupRequest signupRequest)
        {
            Requires()
                .IsNotNullOrEmpty(signupRequest.Name, nameof(signupRequest.Name), "The name cannot be null.");

            Requires()
                .IsEmail(signupRequest.Email, nameof(signupRequest.Email), "Invalid email")
                .IsNotNullOrEmpty(signupRequest.Email, nameof(signupRequest.Email), "The email cannot be null.");

            Requires()
                .IsNotNullOrEmpty(signupRequest.Password, nameof(signupRequest.Password), "The password cannot be null");
        }
    }
}
