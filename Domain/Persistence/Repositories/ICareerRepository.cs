using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Persistence.Repositories
{
    public interface ICareerRepository
    {
        Task<IEnumerable<Career>> ListAsync();
        Task<Career> FindById(int id);
        Task AddAsync(Career career);
        void Update(Career career);
        void Remove(Career career);
    }
}
