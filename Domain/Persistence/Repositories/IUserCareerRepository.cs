using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Persistence.Repositories
{
    public interface IUserCareerRepository
    {
        Task<IEnumerable<UserCareer>> ListAsync();
        Task<IEnumerable<UserCareer>> ListByUserId(int userId);
        Task<IEnumerable<UserCareer>> ListByUniversityId(int universityId);
        Task<IEnumerable<UserCareer>> ListByCareerId(int careerId);
        Task<UserCareer> FindById(int id);
        Task AddAsync(UserCareer userCareer);
        void Update(UserCareer userCareer);
        void Remove(UserCareer userCareer);
        Task AssingUserCareer(int userId, int careerId);
        void UnassignUserCareer(int userId, int careerId);
    }
}
