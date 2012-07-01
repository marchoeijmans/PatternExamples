using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DescriptorPattern.Constants
{
    public class Course
    {
        private string level = CourseLevels.Beginner;

        // not type safe
        public string Level
        {
            get { return level; }
            set { level = value; }
        }

        public bool HasLevel(string level)
        {
            return (Level.Equals(level));
        }
    }
}
