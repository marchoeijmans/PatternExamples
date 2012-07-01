using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PreserveWholeObject.BeforeRefactor
{
    public class TempRange
    {
        private int _low;
        private int _high;

        public TempRange(int low, int high)
        {
            _low = low;
            _high = high;
        }

        public int getLow()
        {
            return _low;
        }

        public int getHigh()
        {
            return _high;
        }
    }
}
