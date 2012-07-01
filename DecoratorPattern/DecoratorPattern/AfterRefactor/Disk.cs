using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.AfterRefactor
{
    public class Disk: ComponentDecorator
    {
        public Disk(Computer arg)
        {
            base.setComputer(arg);
        }

        public override string getDescription()
        {
            return _computer.getDescription() + " en een disk";
        }
    }
}
