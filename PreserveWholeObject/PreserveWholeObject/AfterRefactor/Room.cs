using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PreserveWholeObject.AfterRefactor
{
    public class Room
    {
        public bool withinPlan(HeatingPlan plan)
        {
            return (plan.withinRange(daysTempRange()));
        }
        private TempRange _range = new TempRange(12, 36);

        public TempRange daysTempRange()
        {
            return _range;
        }
    }
}
