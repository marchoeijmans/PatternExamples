namespace BedrijfsklassenPattern.Pattern.ConstantenCollectie
{
    public class Course
    {
        private string courseLevel = CourseLevels.VeryHigh;

        public string CourseLevel
        {
            get { return this.courseLevel; }
            set { this.courseLevel = value; }
        }
    }
}
