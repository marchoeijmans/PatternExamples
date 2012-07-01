using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullableTypeExample.Patterns
{
    public class MagicValuePattern
    {
        private DateTime? date;

        public MagicValuePattern(DateTime? dateToStore)
        {
            this.date = dateToStore;
        }

        public void DoSomething()
        {
            // example of the value or default method
            Console.WriteLine("value or default = " + this.date.GetValueOrDefault(DateTime.Now));

            if (this.date.HasValue)
                // use date.Value
                Console.WriteLine("The date is: {0}", date.Value);
            else
                // DBNull.Value
                Console.WriteLine("The date is undefined, use a special value for storing to the Database, e.g. DBNull.Value");
        }
    }
}
