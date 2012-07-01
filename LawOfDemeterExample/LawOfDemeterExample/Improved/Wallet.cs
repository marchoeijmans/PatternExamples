using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LawOfDemeterExample.Improved
{
    internal class Wallet
    {
        float amount;

        public Wallet(float amountOfDollersInWallet)
        {
            this.amount = amountOfDollersInWallet;
        }

        public float Pay2Dollars()
        {
            if (!this.AmountIsEnoughToPay2Dollars())
            {
                return 0; // don't pay because there is nog enough money to pay
            }

            this.amount -= 2;
            return this.amount;
        }

        public bool AmountIsEnoughToPay2Dollars()
        {
            return this.amount >= 2;
        }
    }
}