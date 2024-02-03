using MyTravelCopilot.Models.Request;
using MyTravelCopilot.Models.Response;

namespace MyTravelCopilot.Repositories.Login
{
    public interface ILoginRepository
    {
        Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
    }
}
