using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Services.Communications
{
    public class ScheduleResponse : BaseResponse<ScheduleResponse>
    {
        public ScheduleResponse(ScheduleResponse resource) : base(resource)
        {
        }

        public ScheduleResponse(string message) : base(message)
        {
        }
    }
}
