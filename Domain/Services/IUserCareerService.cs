using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;
using Gappstone.API.Domain.Services.Communications;

namespace Gappstone.API.Domain.Services
{
    public interface IUserCareerService
    {
        Task<IEnumerable<UserCareer>> ListAsync();
        Task<IEnumerable<UserCareer>> ListByUserIdAsync(int userId);
        Task<IEnumerable<UserCareer>> ListByCareerIdAsync(int careerId);
        Task<IEnumerable<UserCareer>> ListByUniverityIdAsync(int universityId);
        Task<UserCareerResponse> GetByIdAsync(int id);
        Task<UserCareerResponse> SaveAsync(UserCareer userCareer);
        Task<UserCareerResponse> UpdateAsync(int id, UserCareer userCareer);
        Task<UserCareerResponse> DeleteAsync(int id);
    }
}
