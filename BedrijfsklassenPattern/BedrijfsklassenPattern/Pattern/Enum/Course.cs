namespace BedrijfsklassenPattern.Pattern.Enum
{
    public class Course
    {
        private CourseLevels courseLevel = CourseLevels.VeryHigh;

        public CourseLevels CourseLevel
        {
            get { return this.courseLevel; }
            set { this.courseLevel = value; }
        }
    }
}
