using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Services.Communications
{
    public class CountryResponse : BaseResponse<Country>
    {
        public CountryResponse(Country resource) : base(resource)
        {
        }

        public CountryResponse(string message) : base(message)
        {
        }
    }
}
