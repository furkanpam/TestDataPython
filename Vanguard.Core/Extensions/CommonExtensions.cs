using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Core.Extensions
{
    public static class CommonExtensions
    {
        public static T? NullIf<T>(this T value, Predicate<T> condition) where T : struct
        {
            return condition(value) ? null : value;
        }
    }
}
