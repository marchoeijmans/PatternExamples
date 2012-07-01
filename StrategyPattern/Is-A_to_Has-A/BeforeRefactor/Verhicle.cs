using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.BeforeRefactor
{
    public abstract class Verhicle: IGo
    {
        public Verhicle() { }

        // This is a method that can change alot.
        public virtual void go()
        {
            Console.WriteLine("Now I am driving (BR).");
        }
    }
}
