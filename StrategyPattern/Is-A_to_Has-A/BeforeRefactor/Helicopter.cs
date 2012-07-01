using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.BeforeRefactor
{
    public class Helicopter: Verhicle
    {
        public Helicopter() { }

        public override void go()
        {
            Console.WriteLine("Now I am flying (BR).");
        }
    }
}
