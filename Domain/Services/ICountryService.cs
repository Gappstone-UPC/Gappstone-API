using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;
using Gappstone.API.Domain.Services.Communications;

namespace Gappstone.API.Domain.Services
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> ListAsync();
        Task<CountryResponse> GetByIdAsync(int id);
        Task<CountryResponse> SaveAsync(Country country);
        Task<CountryResponse> UpdateAsync(int id, Country country);
        Task<CountryResponse> DeleteAsync(int id);
    }
}
