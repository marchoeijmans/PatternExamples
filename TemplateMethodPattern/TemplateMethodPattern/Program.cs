using System;

using TemplateMethodPattern.Pattern;

namespace TemplateMethodPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AutomativeRobot automotiveRobot = new AutomativeRobot("Automotive robot");
            Console.WriteLine(automotiveRobot.GetName());
            automotiveRobot.Go();

            CookingRobot cookingRobot = new CookingRobot("Cooking robot");
            Console.WriteLine(cookingRobot.GetName());
            cookingRobot.Go();

            CoockingHookRobot cookingHookRobot = new CoockingHookRobot("Cooking hook robot");
            Console.WriteLine(cookingHookRobot.GetName());
            cookingHookRobot.Go();

            Console.ReadLine();
        }
    }
}
