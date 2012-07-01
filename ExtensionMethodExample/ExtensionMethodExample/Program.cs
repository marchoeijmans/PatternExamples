using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ExtensionMethodExample.Logic;

namespace ExtensionMethodExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string myCorrectURL = "http://www.microsoft.com";
            Console.WriteLine(myCorrectURL.IsValidURL());

            string myIncorrectURL = "http:\\www.microsoft.com";
            Console.WriteLine(myIncorrectURL.IsValidURL());

            string myCorrectGUID = new Guid().ToString();
            Console.WriteLine(myCorrectGUID.IsValidGUID40());
            Console.WriteLine(myCorrectGUID.IsValidGUID());

            string myIncorrectGUID = "!@#123243ADB899";
            Console.WriteLine(myIncorrectGUID.IsValidGUID40());
            Console.WriteLine(myIncorrectGUID.IsValidGUID());

            Console.ReadLine();
        }
    }
}
