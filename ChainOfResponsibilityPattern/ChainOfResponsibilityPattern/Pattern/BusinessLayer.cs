namespace ChainOfResponsibilityPattern.Pattern
{
    using System;

    public class BusinessLayer : IHelp
    {
        private IHelp successor;

        public BusinessLayer(IHelp successor)
        {
            this.successor = successor;
        }

        public void GetHelp(HelpConstant helpConstant)
        {
            if (!helpConstant.Equals(HelpConstant.Businesslayer))
            {
                this.successor.GetHelp(helpConstant);
            }
            else
            {
                Console.WriteLine("Help is provided by the business layer.");
            }
        }
    }
}
