using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;
using Gappstone.API.Domain.Services.Communications;

namespace Gappstone.API.Domain.Services
{
    public interface IPaymentService
    {
        Task<IEnumerable<Payment>> ListAsync();
        Task<IEnumerable<Payment>> ListByBillIdAsync();
        Task<IEnumerable<Payment>> ListByTutorIdAsync();
        Task<PaymentResponse> GetByIdAsync(int id);
        Task<PaymentResponse> SaveAsync(Payment payment);
        Task<PaymentResponse> UpdateAsync(int id, Payment payment );
        Task<PaymentResponse> DeleteAsync(int id);
    }
}
