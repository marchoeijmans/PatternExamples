using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.BusinessLayer
{
    public class FirstNameFirst: Namer
    {
        public FirstNameFirst(string arg)
        {
            int indexOfFirstName = arg.IndexOf(" ");

            if (indexOfFirstName > 0)
            {
                _firstName = arg.Substring(0, indexOfFirstName).Trim();
                _lastName = arg.Substring(indexOfFirstName + 1).Trim();
            }
            else
            {
                _lastName = arg;
                _firstName = string.Empty;
            }
        }
    }
}
