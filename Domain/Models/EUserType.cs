using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Gappstone.API.Domain.Models
{
    public enum EUserType: byte
    {
        [Description("Student")]
        Student = 0,
        [Description("Tutor")]
        Tutor = 1
    }
}
