using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Pattern
{
    public class Division : Corporate
    {
        private Corporate[] corporate = new Corporate[100];
        private int number = 0;
        private string name;

        public Division(string name) : base()
        {
            this.name = name;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override void Add(Corporate c)
        {
            this.corporate[this.number++] = c;
        }

        //new?
        public new DivisionIterator Iterator()
        {
            return new DivisionIterator(corporate);
        }

        public override void Print()
        {
            DivisionIterator iterator = this.Iterator();
            while (iterator.HasNext())
            {
                Corporate c = (Corporate)iterator.Next();
                c.Print();
            }
        }
    }
}
