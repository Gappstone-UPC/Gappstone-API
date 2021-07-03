using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gappstone.API.Domain.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public int TotalAmount { get; set; }
        public ECurrency Currency { get; set; }
        public EBillStatus BillStatus { get; set; }
        public string Description { get; set; }
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
        public List<Commission> Commissions { get; set; }
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }

    }
}
