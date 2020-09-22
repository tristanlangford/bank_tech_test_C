using System;
using System.Collections.Generic;

namespace Bank_Tech_Test_C
{
    public class Account
    {
        public double Balance
        { get; private set; }

        public List<Interaction> history = new List<Interaction>();

        public Account()
        {
            Balance = 0;
        }

        public void Deposit(double value)
        {
            if(value <= 0)
            {
                throw new InvalidOperationException("Cannot deposit less than 0.01");
            } else
            {
                Balance += value;
                history.Add(new Interaction(value, Balance, () => DateTime.Now));
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
                Balance -= value;
                history.Add(new Interaction(-value, Balance,() => DateTime.Now));
            }
        }
    }
}
