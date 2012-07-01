using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NullableTypeExample.Patterns;

namespace NullableTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MagicValuePattern magicValueExample1 = new MagicValuePattern(DateTime.Now.AddDays(2.00));
            magicValueExample1.DoSomething();

            MagicValuePattern magicValueExample2 = new MagicValuePattern(null);
            magicValueExample2.DoSomething();

            ExtraBooleanFlagPattern extraBooleanFlagExample1 = new ExtraBooleanFlagPattern(true);
            extraBooleanFlagExample1.DoSomething();

            ExtraBooleanFlagPattern extraBooleanFlagExample2 = new ExtraBooleanFlagPattern(false);
            extraBooleanFlagExample2.DoSomething();

            ExtraBooleanFlagPattern extraBooleanFlagExample3 = new ExtraBooleanFlagPattern(null);
            extraBooleanFlagExample3.DoSomething();

            Person turing = new Person("Alan Turing",
                                new DateTime(1912, 6, 23),
                                new DateTime(1954, 6, 7));
            Console.WriteLine("Turners age is: {0}", turing.Age.ToString());
            Console.WriteLine("Turners age is: {0}", turing.AgeRefactored.ToString());
            Console.WriteLine("Turner was last alive at: {0}",  turing.LastAlive.ToString());
            
            Person knuth = new Person("Donald Knuth",
                                new DateTime(1938, 1, 10),
                                null);
            Console.WriteLine("Knuth age is: {0}", knuth.Age.ToString());
            Console.WriteLine("Knuth age is: {0}", knuth.AgeRefactored.ToString());
            Console.WriteLine("Knuth was last alive at: {0}", knuth.LastAlive.ToString());

            int? parsed = TryParseExample.TryParse("Not valid");
            if (parsed != null)
            {
                Console.WriteLine("Parsed to {0}", parsed.Value);
            }
            else
            {
                Console.WriteLine("Couldn't parse");
            }

            int? parsedValid = TryParseExample.TryParse("2010");
            if (parsedValid != null)
            {
                Console.WriteLine("Parsed to {0}", parsedValid.Value);
            }
            else
            {
                Console.WriteLine("Couldn't parse");
            }

            Console.ReadLine();
        }
    }
}
