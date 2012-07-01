
namespace DecoratorPattern.BeforeRefactor
{
    public class Computer
    {
        public Computer() { }

        /// <summary>
        /// Modificatie is noodzakelijk indien eisen wijzigen.
        /// </summary>
        public string getDescription()
        {
            // refactored return "Dit is een computer.";
            // refactored return "Dit is een computer met harddisk.";
            return "Dit is een computer met harddisk en monitor (BR).";
        }
    }
}
