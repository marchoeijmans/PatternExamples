using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtensionMethodExample.Logic
{
    public static class ExtensionMethods
    {
        public static bool IsValidURL(this string stringToValidate)
        {
            return new Regex(@"http(stringToValidate)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?").IsMatch(stringToValidate);
        }

        public static bool IsValidGUID40(this string stringToValidate)
        {
            // .net 4.0 way to check
            Guid resultGuid; 
            return Guid.TryParse(stringToValidate, out resultGuid);
        }

        public static bool IsValidGUID(this string stringToValidate)
        {
            // option with regular expression
            return new Regex("^[A-Fa-f0-9]{32}$|" +
                "^({|\\()?[A-Fa-f0-9]{8}-([A-Fa-f0-9]{4}-){3}[A-Fa-f0-9]{12}(}|\\))?$|" +
                "^({)?[0xA-Fa-f0-9]{3,10}(, {0,1}[0xA-Fa-f0-9]{3,6}){2}, {0,1}({)([0xA-Fa-f0-9]{3,4}, {0,1}){7}[0xA-Fa-f0-9]{3,4}(}})$").IsMatch(stringToValidate);
        }

    }
}
