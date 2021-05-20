using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Services.Communications
{
    public class UserResponse : BaseResponse<User>
    {
        public UserResponse(User resource) : base(resource)
        {
        }
        public UserResponse(string message) : base(message)
        {
        }
    }
}
