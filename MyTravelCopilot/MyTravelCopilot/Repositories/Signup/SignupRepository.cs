using MyTravelCopilot.Models.Request;
using Flurl.Http;
using Flurl;
using MyTravelCopilot.Helpers;

namespace MyTravelCopilot.Repositories.Signup
{
    public class SignupRepository : ISignupRepository
    {
        public async Task<bool> CreateAsync(SignupRequest request)
        {
            var response = await Constants.ApiUrl
                .AppendPathSegment("/users")
                .PostJsonAsync(request);

            return response.ResponseMessage.IsSuccessStatusCode;
        }
    }
}
