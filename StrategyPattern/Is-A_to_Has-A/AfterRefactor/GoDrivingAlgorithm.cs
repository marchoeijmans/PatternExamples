using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.AfterRefactor
{
    public class GoDrivingAlgorithm: IGoAlgorithm
    {
        public void go()
        {
            Console.WriteLine("I am now driving (AR).");
        }
    }
}
