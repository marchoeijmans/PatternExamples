using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PreserveWholeObject.AfterRefactor
{
    public class HeatingPlan
    {
        private TempRange _range;

        public HeatingPlan(TempRange range)
        {
            _range = range;
        }

        public bool withinRange(TempRange roomRange)
        {
            return (_range.includes(roomRange));
        }
    }
}
