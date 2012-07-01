using System;

using AdapterPattern.Pattern;

namespace AdapterPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OldSystem oldSystem = new OldSystem();
            oldSystem.SetName("Marc Hoeijmans");
            Console.WriteLine(oldSystem.GetName());

            OldSystemToNewSystemAdapter adaper = new OldSystemToNewSystemAdapter(oldSystem);
            Console.WriteLine(adaper.GetFirstName());
            Console.WriteLine(adaper.GetLastName());

            Console.ReadLine();
        }
    }
}
