using System;

using SingletonPattern.Pattern;

namespace SingletonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Database databaseOne = Database.GetInstance("one");
            Console.WriteLine(databaseOne.GetName());

            Database databaseTwo = Database.GetInstance("two");
            Console.WriteLine(databaseTwo.GetName());

            Database databsaeThree = Database.GetInstance("three");
            Console.WriteLine(databsaeThree.GetName());

            Console.ReadLine();
        }
    }
}
