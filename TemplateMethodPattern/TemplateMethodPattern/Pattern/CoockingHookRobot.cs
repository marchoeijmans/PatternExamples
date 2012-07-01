using System;

namespace TemplateMethodPattern.Pattern
{
    public class CoockingHookRobot : RobotHookTemplate
    {
        private string name;

        public CoockingHookRobot(string name)
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

        public string GetName()
        {
            return this.name;
        }

        public override bool TestOk()
        {
            return false;
        }
    }
}
