using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;
using Gappstone.API.Domain.Services.Communications;

namespace Gappstone.API.Domain.Services
{
    public interface ICommissionService
    {
        Task<IEnumerable<Commission>> ListAsync();
        Task<IEnumerable<Commission>> ListByBillIdAsync(int billId);
        Task<IEnumerable<Commission>> ListByTutorshipIdAsync(int tutorShipId);
        Task<CommissionResponse> GetByIdAsync(int id);
        Task<CommissionResponse> SaveAsync(Commission commission);
        Task<CommissionResponse> UpdateAsync(int id, Commission commission);
        Task<CommissionResponse> DeleteAsync(int id);

    }
}
