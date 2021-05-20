using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Services.Communications
{
    public class PaymentResponse : BaseResponse<Payment>
    {
        public PaymentResponse(Payment resource) : base(resource)
        {
        }

        public PaymentResponse(string message) : base(message)
        {
        }
    }
}
