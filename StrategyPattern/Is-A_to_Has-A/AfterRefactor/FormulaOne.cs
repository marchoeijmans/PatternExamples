using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.AfterRefactor
{
    public class FormulaOne: Verhicle
    {
        public FormulaOne()
        {
            setAlgorithm(new GoDrivingAlgorithm());
        }
    }
}
