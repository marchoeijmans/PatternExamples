using System;

namespace TemplateMethodPattern.Pattern
{
    public class AutomativeRobot : RobotTemplate
    {
        private string name;

        public AutomativeRobot(string name)
        {
            this.name = name;
        }

        public override void GetParts()
        {
            Console.WriteLine("Getting a carburetor....");
        }

        public override void Assemble()
        {
            Console.WriteLine("Installing the carburetor....");
        }

        public override void Test()
        {
            Console.WriteLine("Revving the engine....");
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
