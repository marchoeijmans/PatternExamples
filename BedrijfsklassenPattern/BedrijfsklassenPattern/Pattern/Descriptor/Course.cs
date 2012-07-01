namespace BedrijfsklassenPattern.Pattern.Descriptor
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
