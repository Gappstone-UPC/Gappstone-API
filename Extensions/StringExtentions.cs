using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gappstone.API.Extensions
{
    public static class StringExtensions
    {
        public static string ToSnakeCase(this string str)
        {
            if (str != null)
                return string.Concat(
                    str.Select((x, i) => i > 0 &&
                    char.IsUpper(x) ? "_" + x.ToString() :
                    x.ToString())).ToLower();

            return str;
        }
    }
}
