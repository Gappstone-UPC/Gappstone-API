using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Gappstone.API.Domain.Models
{
    public enum ECurrency : byte
    {
        [Description("Dolar")]
        Dolar = 0,
        [Description("Euro")]
        Euro = 1,
        [Description("Sol")]
        Sol = 2,
        [Description("Pesos")]
        Peso = 3

    }
}
