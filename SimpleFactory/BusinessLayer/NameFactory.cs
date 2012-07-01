using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.BusinessLayer
{
    public class NameFactory
    {
        public NameFactory() {}

        public Namer getName(string arg)
        {
            int indexOfLastName = arg.IndexOf(",");
            if (indexOfLastName > 0)
                return new LastNameFirst(arg);    
            else
                return new FirstNameFirst(arg);    
            
        }
    }
}
