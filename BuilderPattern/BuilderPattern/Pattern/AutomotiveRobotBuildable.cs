using System;
using System.Collections.Generic;

namespace BuilderPattern.Pattern
{
    public sealed class AutomotiveRobotBuildable : IRobotBuildable
    {
        private List<int> actions;

        public void Go()
        {
            foreach (int action in this.actions)
            {
                switch (action)
                {
                    case (int)Actions.Start:
                        this.Start();
                        break;
                    case (int)Actions.GetParts:
                        this.GetParts();
                        break;
                    case (int)Actions.Assemble:
                        this.Assemble();
                        break;
                    case (int)Actions.Test:
                        this.Test();
                        break;
                    case (int)Actions.Stop:
                        this.Stop();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public void Start()
        {
            Console.WriteLine("Starting....");
        }

        public void GetParts()
        {
            Console.WriteLine("Getting a carburetor....");
        }

        public void Assemble()
        {
            Console.WriteLine("Installing the carburetor....");
        }

        public void Test()
        {
            Console.WriteLine("Revving the engine....");
        }

        public void LoadActions(List<int> actions)
        {
            this.actions = actions;
        }

        public void Stop()
        {
            Console.WriteLine("Stopping....");
        }
    }
}
