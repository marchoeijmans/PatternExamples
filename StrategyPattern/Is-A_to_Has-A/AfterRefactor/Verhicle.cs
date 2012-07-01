using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.AfterRefactor
{
    public abstract class Verhicle
    {
        private IGoAlgorithm _goAlgorithm;

        public Verhicle() { }

        public void setAlgorithm(IGoAlgorithm arg)
        {
            _goAlgorithm = arg;
        }

        public virtual void go()
        {
            _goAlgorithm.go();
        }
    }
}
