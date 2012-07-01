using System.Collections.Generic;

namespace BuilderPattern.Pattern
{
    public class CookingRobotBuilder : IRobotBuilder
    {
        private CookingRobotBuildable robot;
        private List<int> actions;

        public CookingRobotBuilder()
        {
            this.robot = new CookingRobotBuildable();
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
