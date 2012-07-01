using System;

namespace IteratorPattern.Pattern
{
    public class DivisionIterator : IVicePresidentIterator
    {
        private VicePresident[] vicePresidents;
        private int location = 0;
        
        public DivisionIterator(VicePresident[] vicePresidents)
        {
            this.vicePresidents = vicePresidents;
        }

        public VicePresident Next()
        {
            return this.vicePresidents[this.location++];
        }

        public bool HasNext()
        {
            if (this.location < this.vicePresidents.Length && this.vicePresidents[this.location] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
