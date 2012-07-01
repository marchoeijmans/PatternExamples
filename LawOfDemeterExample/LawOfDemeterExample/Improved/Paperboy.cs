using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LawOfDemeterExample.Improved
{
    internal class Paperboy
    {
        public Paperboy(Customer customerOfPayperBoy)
        {
            this.Customer = customerOfPayperBoy;
        }

        public Customer Customer { get; set; }

        public void GetPayedByCustomer()
        {
            float CurrentAmount = 0;
            CurrentAmount = this.Customer.Pay2Dollars();
            Console.WriteLine(CurrentAmount);
        }
    }
}