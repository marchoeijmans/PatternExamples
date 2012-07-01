using System;
using System.Collections.Generic;

namespace BuilderPattern.Pattern
{
    public sealed class CookingRobotBuildable : IRobotBuildable
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
            Console.WriteLine("Getting flour and sugar....");
        }

        public void Assemble()
        {
            Console.WriteLine("Baking a cookie....");
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
