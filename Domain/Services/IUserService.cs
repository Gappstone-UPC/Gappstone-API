using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;
using Gappstone.API.Domain.Services.Communications;

namespace Gappstone.API.Domain.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> ListAsync();
        Task<IEnumerable<User>> ListByUserCareerIdAsync(int userCareerId);
        Task<IEnumerable<User>> ListByCountryIdAsync(int countryId);
        Task<IEnumerable<User>> ListByCarrerIdAsync(int careerId);
        Task<IEnumerable<User>> ListByUniversityIdAsync(int universityId);
        Task<UserResponse> GetByIdAsync(int id);
        Task<UserCareerResponse> SaveAsync(User user);
        Task<UserResponse> UpdateAsync(int id, User user);
        Task<UserResponse> DeleteAsync(int id);
    }
}
