using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.BeforeRefactor
{
    public class RealJet: Jet
    {
        public RealJet() { }

        public override void go()
        {
            Console.WriteLine("Now I am driving (BR).");
            base.go();
            Console.WriteLine("Now I am driving (BR).");
        }
    }
}
