namespace ChainOfResponsibilityPattern
{
    using System;
    using ChainOfResponsibilityPattern.Pattern;

    public class Program
    {
        public static void Main(string[] args)
        {
            ResourceLayer resourcelayer = new ResourceLayer();
            BusinessLayer businessLayer = new BusinessLayer(resourcelayer);
            PresentationLayer presentationLayer = new PresentationLayer(businessLayer);

            presentationLayer.GetHelp(HelpConstant.General);
            presentationLayer.GetHelp(HelpConstant.Businesslayer);
            presentationLayer.GetHelp(HelpConstant.PresentationLayer);

            Console.ReadLine();
        }
    }
}
