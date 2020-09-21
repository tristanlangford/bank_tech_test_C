using System;
using System.Collections.Generic;

namespace Bank_Tech_Test_C
{
    public class Account
    {
        public double balance
        { get; private set; }

        private Interaction interaction;

        public List<Interaction> InteractionsArray = new List<Interaction>();

        public Account(Interaction interactionClass)
        {
            balance = 0;
            interaction = interactionClass;
        }

        public void Deposit(double value)
        {
            if(value <= 0)
            {
                throw new InvalidOperationException("Cannot deposit less than 0.01");
            } else
            {
                balance += value;
                InteractionsArray.Add(new Interaction(value, balance));
            }
        }

        public void Withdraw(double value)
        {
            if (value <= 0)
            {
                throw new InvalidOperationException("Cannot withdraw less than 0.01");
            }
            else
            {
                balance -= value;
                InteractionsArray.Add(new Interaction(-value, balance));
            }
        }
    }
}
