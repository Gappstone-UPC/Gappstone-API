using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;
using Gappstone.API.Domain.Services.Communications;

namespace Gappstone.API.Domain.Services
{
    public interface IUniversityService
    {
        Task<IEnumerable<University>> ListAsync();
        Task<UniversityResponse> GetByIdAsync(int id);
        Task<UniversityResponse> SaveAsync(University university);
        Task<UniversityResponse> UpdateAsync(int id, University university);
        Task<UniversityResponse> DeleteAsync(int id);
    }
}
