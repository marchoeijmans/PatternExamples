using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.AfterRefactor
{
    public class GloFlyingFastAlgorithm: IGoAlgorithm
    {
        void IGoAlgorithm.go()
        {
            Console.WriteLine("I am flying fast! (AR).");
        }
    }
}
