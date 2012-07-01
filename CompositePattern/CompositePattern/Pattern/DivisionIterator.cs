using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Pattern
{
    public class DivisionIterator : IDivisionIterator
    {
        private Corporate[] corporate;
        private int location = 0;

        public DivisionIterator(Corporate[] c)
        {
            this.corporate = c;
        }

        public bool HasNext()
        {
            return false;
        }

        public Corporate Next()
        {
            return this.corporate[this.location++];
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}