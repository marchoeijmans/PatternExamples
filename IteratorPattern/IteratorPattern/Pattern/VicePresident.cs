using System;

namespace IteratorPattern.Pattern
{
    public class VicePresident
    {
        private string name, division;

        public VicePresident(string name, string division)
        {
            this.name = name;
            this.division = division;
        }

        public string GetName()
        {
            return this.name;
        }

        public void Print()
        {
            Console.WriteLine(this.name + " works in " + this.division);
        }
    }
}
