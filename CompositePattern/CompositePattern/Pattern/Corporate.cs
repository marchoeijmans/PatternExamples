using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Pattern
{
    public abstract class Corporate
    {
        public virtual string GetName()
        {
            return string.Empty;
        }

        public virtual void Add(Corporate c)
        {
        }

        public virtual IDivisionIterator Iterator()
        {
            return null;
        }

        public virtual void Print()
        {
        }
    }
}
