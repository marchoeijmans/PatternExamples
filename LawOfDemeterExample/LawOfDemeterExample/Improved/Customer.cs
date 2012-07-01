using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LawOfDemeterExample.Improved
{
    internal class Customer
    {
        public Customer(string firstName, string lastName, Wallet wallet)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Wallet = wallet;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        private Wallet Wallet { get; set; }

        public float Pay2Dollars()
        {
            return this.Wallet.Pay2Dollars();
        }
    }
}