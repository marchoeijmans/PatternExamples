using System;

using FlyweightPattern.Pattern;

namespace FlyweightPattern
{
    public class Program
    {
        // Running this code gives you the desired results — the flyweight object is configured
        // for each student on-the-fly, and his or her standing, expressed as a
        // percentage offset from the average score, is displayed.
        // So instead of three full objects, you need only one configurable object. Much
        // like the Singleton pattern, the idea behind the Flyweight pattern is to control
        // object creation and limit the number of objects you need.
        public static void Main(string[] args)
        {
            string[] names = { "Sandra", "Jasper", "Sofie" };
            int[] ids = { 1002, 1003, 1004 };
            int[] scores = { 45, 55, 65 };

            double total = 0;
            foreach (int score in scores)
            {
                total += score;
            }

            double averageScore = total / scores.Length;
            Console.WriteLine("The average score: " + averageScore);

            Student student = new Student(averageScore);

            for (int loopIndex = 0; loopIndex < scores.Length; loopIndex++)
            {
                student.SetName(names[loopIndex]);
                student.SetId(ids[loopIndex]);
                student.SetScore(scores[loopIndex]);
                Console.WriteLine("Name: " + student.GetName());
                Console.WriteLine("Standing: " + Math.Round(student.GetStanding()));
            }

            Console.ReadLine();
        }
    }
}
