using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Persistence.Repositories
{
    public interface ICommissionRepository
    {
        Task<IEnumerable<Commission>> ListAsync();
        Task<IEnumerable<Commission>> ListByBillIdAsync(int billId);
        Task<IEnumerable<Commission>> ListByTutorshipIdAsync(int tutorShipId);
        Task<Commission> FindById(int id);
        Task AddAsync(Commission commission);
        void Remove(Commission commission);
        Task AssignCommission(int tutorshipId);
        void UnassignCommission(int tutorshipId);
        
    }
}
