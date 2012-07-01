using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.AfterRefactor
{
    public abstract class ComponentDecorator: Computer
    {
        protected Computer _computer;

        public void setComputer(Computer arg)
        {
            _computer = arg;
        }

        public override string getDescription()
        {
            if (_computer == null) throw new ArgumentNullException("computer is null.");
            return _computer.getDescription();
        }
    }
}
