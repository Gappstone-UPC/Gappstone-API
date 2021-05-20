using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Services.Communications
{
    public class UserCareerResponse : BaseResponse<UserCareer>
    {
        public UserCareerResponse(UserCareer resource) : base(resource)
        {
        }

        public UserCareerResponse(string message) : base(message)
        {
        }
    }
}
