using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Pattern
{
    public class VicePresidentIterator // add Interface to inherit from
    {
        private VicePresident vicePresident;

        public VicePresidentIterator(VicePresident vicePresident)
        {
            this.vicePresident = vicePresident;
        }

        public VicePresident Next()
        {
            return this.vicePresident;
        }

        public bool HasNext()
        {
            return false;
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
