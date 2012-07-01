using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.AfterRefactor
{
    public class Helicopter: Verhicle
    {
        public Helicopter()
        {
            setAlgorithm(new GoFlyingAlgorithm());
        }
    }
}
