using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullableTypeExample.Patterns
{
    public static class TryParseExample
    {
        // TryXXX pattern; The nullable version encapsulates the natural return value and the success or failure into a single variable.
        public static int? TryParse(string text)
        {
            int ret;
            if (int.TryParse(text, out ret))
            {
                return ret;
            }
            else
            {
                return null;
            }
        }
    }
}
