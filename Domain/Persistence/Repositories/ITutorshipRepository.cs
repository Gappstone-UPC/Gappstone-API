using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Persistence.Repositories
{
    public interface ITutorshipRepository
    {
        Task<IEnumerable<Tutorship>> ListAsync();
        Task<IEnumerable<Tutorship>> ListByTutorIdAsync(int tutorId);
        Task<IEnumerable<Tutorship>> ListByStudentIdAsync(int studentId);
        Task<Tutorship> FindById(int id);
        Task<Tutorship> AddAsync(Tutorship tutorship);
        void Update(Tutorship tutorship);
        void Remove(Tutorship tutorship);

    }
}
