using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PreserveWholeObject.BeforeRefactor
{
    public class Room
    {
        public bool withinPlan(HeatingPlan plan)
        {
            int low = daysTempRange().getLow();
            int high = daysTempRange().getHigh();
            return (plan.withinRange(low, high));
        }
        private TempRange _range = new TempRange(12, 36);

        public TempRange daysTempRange()
        {
            return _range;
        }
    }
}
