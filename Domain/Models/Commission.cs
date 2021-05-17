using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gappstone.API.Domain.Models
{
    public class Commission
    {  
        public int CommissionId { get; set; }
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
        public int BillId { get; set; }
        public Bill Bill { get; set; }
        public decimal Amount { get; set; }
    }
}
