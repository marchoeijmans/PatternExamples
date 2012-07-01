using System;

namespace TemplateMethodPattern.Pattern
{
    public class CookingRobot : RobotTemplate
    {
        private string name;

        public CookingRobot(string name)
        {
            this.name = name;
        }

        public override void GetParts()
        {
            Console.WriteLine("Getting flour and sugar....");
        }

        public override void Assemble()
        {
            Console.WriteLine("Baking a cookie....");
        }

        public override void Test()
        {
            Console.WriteLine("Crunching a cookie....");
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
