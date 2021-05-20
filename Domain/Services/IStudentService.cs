using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;
using Gappstone.API.Domain.Services.Communications;

namespace Gappstone.API.Domain.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> ListAsync();
        Task<IEnumerable<Student>> ListByUserCareerIdAsync(int userCareerId);
        Task<IEnumerable<Student>> ListByCareerIdAsync(int careerId);
        Task<IEnumerable<Student>> ListByUniversityIdAsync(int universityId);
        Task<IEnumerable<Student>> ListByCountryIdAsync(int countryId);
        Task<UserResponse> GetByIdAsync(int id);
        Task<UserResponse> SaveAsync(User user);
        Task<UserResponse> UpdateAsync(int id, User user);
        Task<UserResponse> DeleteAsync(int id);
    }
}
