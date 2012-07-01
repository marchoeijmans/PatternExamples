using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.AfterRefactor
{
    public class Computer
    {
        public Computer() { }

        public virtual string getDescription()
        {
            return "computer";
        }
    }
}
