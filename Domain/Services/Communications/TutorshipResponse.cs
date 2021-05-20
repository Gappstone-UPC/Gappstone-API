using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Services.Communications
{
    public class TutorshipResponse : BaseResponse<Tutorship>
    {
        public TutorshipResponse(Tutorship resource) : base(resource)
        {
        }

        public TutorshipResponse(string message) : base(message)
        {
        }
    }
}
