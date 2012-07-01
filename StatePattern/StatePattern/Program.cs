using System;

using BR = StatePattern.Pattern.BeforeRefactor;
using AR = StatePattern.Pattern.AfterRefactor;

namespace StatePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BR.Automat retalAutomat1 = new BR.Automat(10);
            //retalAutomat1.GetApplication();
            //retalAutomat1.CheckApplication();

            AR.Automat rentalAutomat2 = new AR.Automat(10);
            rentalAutomat2.GotApplication();
            rentalAutomat2.CheckApplication();
            rentalAutomat2.RentApartment();

            Console.ReadLine();
        }
    }
}
