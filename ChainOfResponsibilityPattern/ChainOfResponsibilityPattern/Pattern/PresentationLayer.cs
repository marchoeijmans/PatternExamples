namespace ChainOfResponsibilityPattern.Pattern
{
    using System;
    
    public class PresentationLayer : IHelp
    {
        private IHelp successor;

        public PresentationLayer(IHelp successor)
        {
            this.successor = successor;
        }

        public void GetHelp(HelpConstant helpConstant)
        {
            if (!helpConstant.Equals(HelpConstant.PresentationLayer))
            {
                this.successor.GetHelp(helpConstant);
            }
            else
            {
                Console.WriteLine("Help is provided by the presentation layer.");
            }
        }
    }
}
