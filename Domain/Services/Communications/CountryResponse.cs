using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Services.Communications
{
    public class CountryRespons : BaseResponse<Country>
    {
        public CountryRespons(Country resource) : base(resource)
        {
        }

        public CountryRespons(string message) : base(message)
        {
        }
    }
}
