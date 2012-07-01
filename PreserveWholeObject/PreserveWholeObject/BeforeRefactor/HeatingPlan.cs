using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PreserveWholeObject.BeforeRefactor
{
    public class HeatingPlan
    {
        private TempRange _range;

        public HeatingPlan(TempRange range)
        {
            _range = range;
        }

        public bool withinRange(int low, int high)
        {
            return (low >= _range.getLow() && high <= _range.getHigh());
        }
    }
}
