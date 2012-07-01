namespace ChainOfResponsibilityPattern.Pattern
{
    using System;
    
    public class ResourceLayer : IHelp
    {
        public ResourceLayer()
        {
        }

        public void GetHelp(HelpConstant helpConstant)
        {
            Console.WriteLine("General help is provided by the resource layer.");
        }
    }
}
