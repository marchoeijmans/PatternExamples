using System;

namespace TemplateMethodPattern.Pattern
{
    public abstract class RobotHookTemplate
    {
        public RobotHookTemplate()
        {
        }

        public void Go()
        {
            this.Start();
            this.GetParts();
            this.Assemble();

            if (this.TestOk())
            {
                this.Test();
            }

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

        public virtual bool TestOk()
        {
            return true;
        }
    }
}
