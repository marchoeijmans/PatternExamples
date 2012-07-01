using System.Collections.Generic;

namespace BuilderPattern.Pattern
{
    public class AutomotiveRobotBuilder : IRobotBuilder
    {
        private AutomotiveRobotBuildable robot;
        private List<int> actions;

        public AutomotiveRobotBuilder()
        {
            this.robot = new AutomotiveRobotBuildable();
            this.actions = new List<int>();
        }

        public void AddStart()
        {
            this.actions.Add((int)Actions.Start);
        }

        public void AddGetParts()
        {
            this.actions.Add((int)Actions.GetParts);
        }

        public void AddAssemble()
        {
            this.actions.Add((int)Actions.Assemble);
        }

        public void AddTest()
        {
            this.actions.Add((int)Actions.Test);
        }

        public void AddStop()
        {
            this.actions.Add((int)Actions.Stop);
        }

        public IRobotBuildable GetRobot()
        {
            this.robot.LoadActions(this.actions);
            return this.robot;
        }
    }
}
