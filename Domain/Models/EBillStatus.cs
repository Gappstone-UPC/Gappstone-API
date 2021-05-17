using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Gappstone.API.Domain.Models
{
    public enum EBillStatus
    {
        [Description("Pending")]
        Pending = 0,
        [Description("Paid")]
        Paid = 10,
        [Description("Overdue")]
        Overdue = 20
    }
}
