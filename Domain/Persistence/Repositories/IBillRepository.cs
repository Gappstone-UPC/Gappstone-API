using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Persistence.Repositories
{
    public interface IBillRepository
    {
        Task<IEnumerable<Bill>> ListAsync();
        Task<IEnumerable<Bill>> ListByTutorId(int tutorId);
        Task AddAsync(Bill bill);
        Task<Bill> FindById(int id);
    }
}
