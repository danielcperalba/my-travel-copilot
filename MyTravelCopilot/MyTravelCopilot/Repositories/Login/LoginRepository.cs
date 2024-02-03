using Flurl;
using Flurl.Http;
using MyTravelCopilot.Helpers;
using MyTravelCopilot.Models.Request;
using MyTravelCopilot.Models.Response;

namespace MyTravelCopilot.Repositories.Login
{
    public class LoginRepository : ILoginRepository
    {
        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            var response = await Constants.ApiUrl
                .AppendPathSegment("/users/login")
                .PutJsonAsync(loginRequest);

            if(response.ResponseMessage.IsSuccessStatusCode)
            {
                var content = await response.ResponseMessage.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<LoginResponse>(content);
            }

            return new LoginResponse();
        }
    }
}
