using System;

using BedrijfsklassenPattern.Pattern;
using DE = BedrijfsklassenPattern.Pattern.Descriptor;
using EN = BedrijfsklassenPattern.Pattern.Enum;

namespace BedrijfsklassenPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Course myUgglyCourse = new Course();
            myUgglyCourse.Level = "VeryHigh";

            if (myUgglyCourse.Level == "VeryHigh")
            {
                Console.WriteLine("Uggly course courseLevel is: " + myUgglyCourse.Level);
            }

            EN.Course constantenCollectieCourse = new EN.Course();
            if (constantenCollectieCourse.CourseLevel == EN.CourseLevels.VeryHigh)
            {
                Console.WriteLine("Enum course CourseLevel is: " + constantenCollectieCourse.CourseLevel);
            }

            DE.Course descriptorCourse = new DE.Course();
            if (descriptorCourse.CourseLevel == DE.CourseLevels.VeryHigh)
            {
                Console.WriteLine("Descriptor CourseLevel is: " + descriptorCourse.CourseLevel.GetDisplayValue() + " code: " + descriptorCourse.CourseLevel.GetCode());
            }

            Console.ReadLine();
        }
    }
}
