using MyTravelCopilot.Models.Request;
using MyTravelCopilot.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTravelCopilot.Repositories.Spent
{
    public interface IExpensesRepository
    {
        Task<IEnumerable<ExpensesResponse>> GetExpensesAsync();
        Task<bool> AddAsync(ExpensesRequest expensesRequest);
        Task<bool> UpdateAsync(ExpensesRequest expensesRequest);
    }
}
