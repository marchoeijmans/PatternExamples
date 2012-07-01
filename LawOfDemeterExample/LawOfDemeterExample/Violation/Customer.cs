using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LawOfDemeterExample.Violation
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

        public Wallet Wallet { get; private set; }
    }
}