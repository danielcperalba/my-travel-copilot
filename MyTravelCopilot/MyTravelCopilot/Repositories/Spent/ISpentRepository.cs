using MyTravelCopilot.Models.Request;
using MyTravelCopilot.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTravelCopilot.Repositories.Spent
{
    public interface ISpentRepository
    {
        Task<IEnumerable<SpentResponse>> GetSpentAsyc();
        Task<bool> AddAsync(SpentRequest spentRequest);
        Task<bool> UpdateAsync(SpentRequest spentRequest);
    }
}
