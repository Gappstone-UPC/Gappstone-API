using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;
using Gappstone.API.Domain.Services.Communications;

namespace Gappstone.API.Domain.Services
{
    public interface ITutorService
    {
        Task<IEnumerable<Tutor>> ListAsync();
        Task<IEnumerable<Tutor>> ListByUserCareerIdAsync(int userCareerId);
        Task<IEnumerable<Tutor>> ListByCareerIdAsync(int careerId);
        Task<IEnumerable<Tutor>> ListByUniversityIdAsync(int universityId);
        Task<IEnumerable<Tutor>> ListByCountryIdAsync(int countryId);
        Task<TutorResponse> GetByIdAsync(int id);
        Task<TutorResponse> SaveAsync(Tutor tutor);
        Task<TutorResponse> UpdateAsync(int id, Tutor tutor);
        Task<TutorResponse> DeleteAsync(int id);
    }
}
