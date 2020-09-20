using System;
namespace Bank_Tech_Test_C
{
    public class Account
    {
        public double balance
        { get; private set; }

        public Account()
        {
            balance = 0;
        }

        public void Deposit(double value)
        {
            balance += value;
        }
    }
}
