using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.BusinessLayer
{
    public class Namer
    {
        protected string _firstName, _lastName;

        public string getFirstName()
        {
            return _firstName;
        }

        public string getLastName()
        {
            return _lastName;
        }
    }
}
