using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Services.Communications
{
    public class TutorResponse : BaseResponse<Tutor>
    {
        public TutorResponse(Tutor resource) : base(resource)
        {
        }

        public TutorResponse(string message) : base(message)
        {
        }
    }
}
