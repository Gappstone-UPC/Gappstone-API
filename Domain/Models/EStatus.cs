using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Gappstone.API.Domain.Models
{
    public enum EStatus: byte
    {
        [Description("Desable")]
        Desable = 0,
        [Description("Admonished")]
        Admonished = 10,
        [Description("Active")]
        Active = 20
    }
}
