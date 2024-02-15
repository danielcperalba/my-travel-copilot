using MyTravelCopilot.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTravelCopilot.Repositories.Signup
{
    public interface ISignupRepository
    {
        Task<bool> CreateAsync(SignupRequest request);
    }
}
