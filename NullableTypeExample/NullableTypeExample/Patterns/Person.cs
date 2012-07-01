using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullableTypeExample.Patterns
{
    public class Person
    {
        DateTime birth;
        DateTime? death;
        string name;
        public TimeSpan Age
        {
            get
            {
                if (death == null)
                {
                    return DateTime.Now - birth;
                }
                else
                {
                    return death.Value - birth;
                }
            }
        }

        public TimeSpan AgeRefactored
        {
            get
            {
                return LastAlive - birth;
            }
        }


        public DateTime LastAlive
        {
            get 
            {
                // example of coalescing operator, same as if death.HasValue, the use value, otherwise use DateTime.Now
                return (death ?? DateTime.Now);
            }
        }

        public Person(string name,
        DateTime birth,
        DateTime? death)
        {
            this.birth = birth;
            this.death = death;
            this.name = name;
        }
    }
}
