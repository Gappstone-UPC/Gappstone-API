using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Services.Communications
{
    public class CommissionResponse : BaseResponse<Commission>
    {
        public CommissionResponse(Commission resource) : base(resource)
        {
        }

        public CommissionResponse(string message) : base(message)
        {
        }
    }
}
