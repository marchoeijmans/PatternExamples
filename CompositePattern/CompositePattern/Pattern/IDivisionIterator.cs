using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Pattern
{
    public interface IDivisionIterator
    {
        Corporate Next();

        bool HasNext();

        void Remove();
    }
}
