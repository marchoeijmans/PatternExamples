using System;

using BuilderPattern.Pattern;

namespace BuilderPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Construct the cooking robot
            CookingRobotBuilder cookingBuilder = new CookingRobotBuilder();
            cookingBuilder.AddStart();
            cookingBuilder.AddGetParts();
            cookingBuilder.AddGetParts();
            cookingBuilder.AddAssemble();
            cookingBuilder.AddStop();

            // Do the robot cooking work
            cookingBuilder.GetRobot().Go();

            // Construct the automotive robot
            AutomotiveRobotBuilder automotiveBuilder = new AutomotiveRobotBuilder();
            automotiveBuilder.AddGetParts();
            automotiveBuilder.AddAssemble();
            automotiveBuilder.AddStart();
            automotiveBuilder.AddTest();
            automotiveBuilder.AddStop();

            // Do the automotive robot work
            automotiveBuilder.GetRobot().Go();

            Console.ReadLine();
        }
    }
}
