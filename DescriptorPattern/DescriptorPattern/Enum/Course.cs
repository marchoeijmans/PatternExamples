using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DescriptorPattern.Enum
{
    public class Course
    {
        private CourseLevels level = CourseLevels.Beginner;

        public CourseLevels Level
        {
            get { return level; }
            set { level = value; }
        }

        public bool HasLevel(CourseLevels level)
        {
            return (Level == level);
        }
    }
}
