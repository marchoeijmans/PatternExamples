using System;
using FacadePattern.Pattern;

namespace FacadePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DifficultProduct difficultProduct = new DifficultProduct();
            difficultProduct.SetFirstNameCharacter('p');
            difficultProduct.SetSecondNameCharacter('r');
            difficultProduct.SetThirdNameCharacter('i');
            difficultProduct.SetFourthNameCharacter('n');
            difficultProduct.SetFifthNameCharacter('t');
            difficultProduct.SetSixthNameCharacter('e');
            difficultProduct.SetSeventhNameCharacter('r');

            Console.WriteLine(difficultProduct.GetName());

            SimpleProductFacade simpleProduct = new SimpleProductFacade();
            simpleProduct.SetName("printer");

            Console.WriteLine(simpleProduct.GetName());

            Console.ReadLine();
        }
    }
}
