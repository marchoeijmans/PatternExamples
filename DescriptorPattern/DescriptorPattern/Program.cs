using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EN = DescriptorPattern.Enum;
using DP = DescriptorPattern.Pattern;

namespace DescriptorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Enum example (inheritence is not possible, not good for UI displaying)
            EN.Course myCourse = new EN.Course();
            //myCourse.Level = EN.CourseLevels.Advanced;

            if (myCourse.Level.Equals(EN.CourseLevels.Beginner))
                Console.WriteLine("Beginner");
            else
                Console.WriteLine("Geen beginner");
            
            if (myCourse.HasLevel(EN.CourseLevels.Beginner))
                Console.WriteLine("Beginner");
            else
                Console.WriteLine("Geen beginner");

            // Constants collection (inheritance is possible)

            // Descriptor pattern example
            DP.CourseLevels myCourseLevel = DP.CourseLevels.Advanced;

            Console.ReadLine();
            
        }
    }
}
