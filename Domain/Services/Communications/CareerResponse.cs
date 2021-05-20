using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Services.Communications
{
    public class CareerResponse : BaseResponse<Career>
    {
        public CareerResponse(Career resource) : base(resource)
        {
        }

        public CareerResponse(string message) : base(message)
        {
        }
    }
}
