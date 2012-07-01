using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullableTypeExample.Patterns
{
    // Pattern 2: reference type wrapper
    // Pattern 3: extra boolean flag

    class ExtraBooleanFlagPattern
    {
        private bool? isValid;

        public ExtraBooleanFlagPattern(bool? valid = true)
        {
            this.isValid = valid;
        }

        public void DoSomething()
        {
            // example of the value or default method
            Console.WriteLine("value or default = " + this.isValid.GetValueOrDefault());
            
            if (this.isValid.HasValue)
            {
                if (this.isValid.Value.Equals(true))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
            else
                Console.WriteLine("Maybe");
        }
    }
}
