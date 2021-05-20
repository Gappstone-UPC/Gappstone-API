using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Services.Communications
{
    public class BillResponse : BaseResponse<Bill>
    {
        public BillResponse(Bill resource) : base(resource)
        {
        }

        public BillResponse(string message) : base(message)
        {
        }
    }
}
