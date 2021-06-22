using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Persistence.Repositories
{
    public interface ITutorRepository
    {
        Task<IEnumerable<Tutor>> ListAsync();
        Task<Tutor> FindById(int id);
        Task AddAsync(Tutor tutor);
        void Update(Tutor tutor);
        void Remove(Tutor tutor);
    }
}
