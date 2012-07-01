using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.AfterRefactor
{
    class Monitor: ComponentDecorator
    {
        public Monitor(Computer arg)
        {
            base.setComputer(arg);
        }

        public override string getDescription()
        {
            return _computer.getDescription() + " en een monitor (AR).";
        }
    }
}
