using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;

namespace DescriptorPattern.Pattern
{
    // Een descriptor is een klasse die als properties een collectie instanties van zichzelf kent.
    public class CourseLevels
    {
        public static string DisplayValue;

        public CourseLevels(string displayvalue)
        {
            DisplayValue = displayvalue;
        }
        public static CourseLevels Beginner = new CourseLevels("“Beginner");
        public static CourseLevels Advanced = new CourseLevels("Advanced");
        public static CourseLevels VeryHigh = new CourseLevels("Very high");
        public static CourseLevels Expert = new CourseLevels("Expert");
    }
}
