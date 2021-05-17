using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gappstone.API.Domain.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
        public int PaymentCode { get; set; }
        public int BillId { get; set; }
        public Bill Bill { get; set; }
        public string ImageUrl { get; set; }
    }
}
