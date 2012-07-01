namespace FlyweightPattern.Pattern
{
    public class Student
    {
        private int id;
        private string name;
        private int score;
        private double averageScore;

        public Student(double averageScore)
        {
            this.averageScore = averageScore;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetScore(int score)
        {
            this.score = score;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetScore()
        {
            return this.score;
        }

        public double GetStanding()
        {
            return ((((double)this.score) / this.averageScore) - 1.0) * 100.0;
        }
    }
}
