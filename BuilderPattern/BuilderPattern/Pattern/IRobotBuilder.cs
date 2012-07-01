namespace BuilderPattern.Pattern
{
    public interface IRobotBuilder
    {
        void AddStart();

        void AddGetParts();

        void AddAssemble();

        void AddStop();

        IRobotBuildable GetRobot();
    }
}
