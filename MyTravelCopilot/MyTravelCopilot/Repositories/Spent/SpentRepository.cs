using MyTravelCopilot.Models.Request;
using MyTravelCopilot.Models.Response;
using MyTravelCopilot.Helpers;
using Flurl;
using Flurl.Http;

namespace MyTravelCopilot.Repositories.Spent
{
    public class SpentRepository : ISpentRepository
    {
        public async Task<IEnumerable<SpentResponse>> GetSpentAsyc()
        {
            return await Constants.ApiUrl
                .AppendPathSegment("/spents")
                .WithOAuthBearerToken(Preferences.Get("token", string.Empty))
                .GetJsonAsync<IEnumerable<SpentResponse>>();

        }
        public async Task<bool> AddAsync(SpentRequest spentRequest)
        {
            var response = await Constants.ApiUrl
                .AppendPathSegment("/spents")
                .WithOAuthBearerToken(Preferences.Get("token", string.Empty))
                .PostJsonAsync(spentRequest);

            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public Task<bool> UpdateAsync(SpentRequest spentRequest)
        {
            throw new NotImplementedException();
        }
    }
}
