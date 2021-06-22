using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Persistence.Repositories
{
    public interface IUniversityRepository
    {
        Task<IEnumerable<University>> ListAsync();
        Task<University> FindById(int id);
        Task AddAsync(University university);
        void Update(University university);
        void Remove(University university);
    }
}
