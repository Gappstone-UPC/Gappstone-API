using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;
using Gappstone.API.Domain.Services.Communications;

namespace Gappstone.API.Domain.Services
{
    public interface ICareerService
    {
        Task<IEnumerable<Career>> ListAsync();
        Task<CareerResponse> GetByIdAsync(int id);
        Task<CareerResponse> SaveAsync(Career career);
        Task<CareerResponse> UpdateAsync(int id, Career career);
        Task<CareerResponse> DeleteAsync(int id);
    }
}
