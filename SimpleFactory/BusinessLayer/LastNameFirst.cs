using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.BusinessLayer
{
    public class LastNameFirst: Namer
    {
        public LastNameFirst(string arg)
        {
            int indexOfLastName = arg.IndexOf(",");

            if (indexOfLastName > 0)
            {
                _lastName = arg.Substring(0, indexOfLastName).Trim();
                _firstName = arg.Substring(indexOfLastName + 1).Trim();
            }
            else
            {
                _lastName = arg;
                _firstName = string.Empty;
            }
        }
    }
}
