using System;

namespace TemplateMethodPattern.Pattern
{
    public abstract class RobotTemplate
    {
        public RobotTemplate()
        {
        }

        public void Go()
        {
            this.Start();
            this.GetParts();
            this.Assemble();
            this.Test();
            this.Stop();
        }

        public void Start()
        {
            Console.WriteLine("Starting....");
        }

        public virtual void GetParts()
        {
            Console.WriteLine("Getting parts....");
        }

        public virtual void Assemble()
        {
            Console.WriteLine("Assembling....");
        }

        public virtual void Test()
        {
            Console.WriteLine("Testing....");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping....");
        }
    }
}
