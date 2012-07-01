namespace BedrijfsklassenPattern.Pattern.Descriptor
{
    public class CourseLevels
    {
        public static CourseLevels Beginner = new CourseLevels("Beginner", "BEG");
        public static CourseLevels Advanced = new CourseLevels("Advanced", "ADV");
        public static CourseLevels VeryHigh = new CourseLevels("Very high", "VHG");
        public static CourseLevels Expert = new CourseLevels("Expert", "EXP");

        private string displayValue;
        private string code; 

        public CourseLevels(string displayvalue, string code)
        {
            this.displayValue = displayvalue;
            this.code = code;
        }

        public string GetDisplayValue()
        {
            return this.displayValue;
        }

        public string GetCode()
        {
            return this.code;
        }
    }
}
