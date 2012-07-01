using System;

namespace StatePattern.Pattern.BeforeRefactor
{
    public class Automat
    {
        public const int FullyRented = 0;
        public const int Waiting = 1;
        public const int GotApplication = 2;

        private const int ApartmentRented = 3;
        private Random random;
        private int numberApartments;
        private int state = Waiting;

        public Automat(int n)
        {
            this.numberApartments = n;
            this.random = new Random(System.DateTime.Now.TimeOfDay.Milliseconds);
        }

        public void GetApplication()
        {
            switch (this.state)
            {
                case FullyRented:
                    Console.WriteLine("Sorry, we’re fully rented.");
                    break;
                case Waiting:
                    this.state = GotApplication;
                    Console.WriteLine("Thanks for the application.");
                    break;
                case GotApplication:
                    Console.WriteLine("We already got your application.");
                    break;
                case ApartmentRented:
                    Console.WriteLine("Hang on, we’re renting you an apartment.");
                    break;
            }
        }

        public void CheckApplication()
        {
            int yesno = this.random.Next(100) % 10;
            switch (this.state)
            {
                case FullyRented:
                    Console.WriteLine("Sorry, we’re fully rented.");
                    break;
                case Waiting:
                    Console.WriteLine("You have to submit an application.");
                    break;
                case GotApplication:
                    if (yesno > 4 && this.numberApartments > 0)
                    {
                        Console.WriteLine("Congratulations, you were approved.");
                        this.state = ApartmentRented;
                        this.RentApartment();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you were not approved.");
                        this.state = Waiting;
                    }

                    break;
                case ApartmentRented:
                    Console.WriteLine("Hang on, we’re renting you an apartment.");
                    break;
            }
        }

        public void RentApartment()
        {
            switch (this.state)
            {
                case FullyRented:
                    Console.WriteLine("Sorry, we’re fully rented.");
                    break;
                case Waiting:
                    Console.WriteLine("You have to submit an application.");
                    break;
                case GotApplication:
                    Console.WriteLine("You must have your application checked.");
                    break;
                case ApartmentRented:
                    Console.WriteLine("Renting you an apartment....");
                    this.numberApartments--;
                    this.DispenseKeys();
                    break;
            }
        }

        public void DispenseKeys()
        {
            switch (this.state)
            {
                case FullyRented:
                    Console.WriteLine("Sorry, we’re fully rented.");
                    break;
                case Waiting:
                    Console.WriteLine("You have to submit an application.");
                    break;
                case GotApplication:
                    Console.WriteLine("You must have your application checked.");
                    break;
                case ApartmentRented:
                    Console.WriteLine("Here are your keys!");
                    this.state = Waiting;
                    break;
            }
        }
    }
}
