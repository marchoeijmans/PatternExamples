using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.AfterRefactor
{
    public class CD: ComponentDecorator
    {
        public CD(Computer arg)
        {
            base.setComputer(arg);
        }
        
        public override string getDescription()
        {
            return base.getDescription() + " en een CD";
        }
    }
}
