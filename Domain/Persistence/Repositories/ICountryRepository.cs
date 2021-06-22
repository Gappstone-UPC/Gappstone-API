using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Persistence.Repositories
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> ListAsync();
        Task AddAsync(Country country);
        Task<Country> FindById(int id);
        void Update(Country country);
        void Remove(Country country);
        
    }
}
