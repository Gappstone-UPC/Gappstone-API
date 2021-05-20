using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;
using Gappstone.API.Domain.Services.Communications;

namespace Gappstone.API.Domain.Services
{
    public interface IBillService
    {
        Task<IEnumerable<Bill>> ListAsync();
        Task<IEnumerable<Bill>> ListByTutorIdAsync(int tutorId);
        Task<IEnumerable<Bill>> ListByPaymentIdAsync(int PaymentId);
        Task<BillResponse> GetByIdAsync(int id);
        Task<BillResponse> SaveAsync();
        Task<BillResponse> UpdateAsync(int id, Bill bill);
        Task<BillResponse> DeleteAsync(int id);
    }
}
