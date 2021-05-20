using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Services.Communications
{
    public class Schedule : BaseResponse<Schedule>
    {
        public Schedule(Schedule resource) : base(resource)
        {
        }

        public Schedule(string message) : base(message)
        {
        }
    }
}
