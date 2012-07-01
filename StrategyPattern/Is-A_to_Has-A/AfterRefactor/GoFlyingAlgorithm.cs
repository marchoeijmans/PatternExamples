using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.AfterRefactor
{
    public class GoFlyingAlgorithm: IGoAlgorithm
    {
        void IGoAlgorithm.go()
        {
            Console.WriteLine("I am now flying (AR).");
        }
    }
}
