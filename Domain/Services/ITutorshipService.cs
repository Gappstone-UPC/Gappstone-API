using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;
using Gappstone.API.Domain.Services.Communications;

namespace Gappstone.API.Domain.Services
{
    public interface ITutorshipService
    {
        Task<IEnumerable<Tutorship>> ListAsync();
        Task<IEnumerable<Tutorship>> ListByStudentIdAsync(int studentId);
        Task<IEnumerable<Tutorship>> ListByScheduleIdAsync(int scheduleId);
        Task<IEnumerable<Tutorship>> ListByTutorIdAsync(int tutorId);
        Task<TutorResponse> GetByIdAsync(int id);
        Task<TutorResponse> SaveAsync(int id);
        Task<TutorResponse> UpdateAsync(int id, Tutorship tutorship);
        Task<TutorResponse> DeleteAsync(int id);

    }
}
