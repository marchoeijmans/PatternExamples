using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.BeforeRefactor
{
    public class Jet: Verhicle
    {
        public Jet() { }

        public override void go()
        {
            Console.WriteLine("Now I am flying fast (BR).");
        }
    }
}
