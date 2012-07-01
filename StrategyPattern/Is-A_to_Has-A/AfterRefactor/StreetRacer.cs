using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.AfterRefactor
{
    public class StreetRacer: Verhicle
    {
        public StreetRacer()
        {
            setAlgorithm(new GoDrivingAlgorithm());
        }
    }
}
