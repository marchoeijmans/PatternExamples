using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Pattern
{
    public class VicePresident : Corporate
    {
        private string name, division;

        public VicePresident(string name, string division)
        {
            this.name = name;
            this.division = division;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override void Print()
        {
            Console.WriteLine(this.name + " works in " + this.division);
        }

        public new VicePresidentIterator Iterator()
        {
            return new VicePresidentIterator(this);
        }
    }
}
