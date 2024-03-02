using MyTravelCopilot.Models.Request;
using MyTravelCopilot.Models.Response;
using MyTravelCopilot.Helpers;
using Flurl;
using Flurl.Http;

namespace MyTravelCopilot.Repositories.Spent
{
    public class ExpensesRepository : IExpensesRepository
    {
        public async Task<IEnumerable<ExpensesResponse>> GetExpensesAsync()
        {
            return await Constants.ApiUrl
                .AppendPathSegment("/expenses")
                .WithOAuthBearerToken(Preferences.Get("token", string.Empty))
                .GetJsonAsync<IEnumerable<ExpensesResponse>>();

        }
        public async Task<bool> AddAsync(ExpensesRequest expensesRequest)
        {
            var response = await Constants.ApiUrl
                .AppendPathSegment("/expenses")
                .WithOAuthBearerToken(Preferences.Get("token", string.Empty))
                .PostJsonAsync(expensesRequest);

            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public Task<bool> UpdateAsync(ExpensesRequest expensesRequest)
        {
            throw new NotImplementedException();
        }

    }
}
