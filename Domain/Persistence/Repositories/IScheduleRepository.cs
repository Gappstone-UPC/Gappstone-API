using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Persistence.Repositories
{
    public interface IScheduleRepository
    {
        Task<IEnumerable<Schedule>> ListAsync();
        Task<IEnumerable<Schedule>> ListByTutorId(int tutorId);
        Task<Schedule> FindById(int id);
        Task AddAsync(Schedule schedule);
        void Update(Schedule schedule);
        void Remove(Schedule schedule);
    }
}
