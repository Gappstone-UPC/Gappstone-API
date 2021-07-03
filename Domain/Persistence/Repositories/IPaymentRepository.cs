using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Persistence.Repositories
{
    public interface IPaymentRepository
    {
        Task<IEnumerable<Payment>> ListAsync();
        Task<IEnumerable<Payment>> ListByBillIdAsync(int billId);
        Task<IEnumerable<Payment>> ListByTutorIdAsync(int tutorId);
        Task AddAsync(Payment payment);
        void Remove(Payment payment);
        Task AssingBill(int tutorId, int billId, DateTime date);
        void UnassignBill(int tutorId, int billId, DateTime date);

    }
}
