using System;
namespace Bank_Tech_Test_C
{
    public class Interaction : IInteraction
    {
        private double OldBalance;

        private double NewBalance;

        private string Date;

        public Interaction(double value, double oldBalance)
        {
            OldBalance = oldBalance;
            NewBalance = OldBalance + value;
            Date = DateTime.Now.ToString("dd-MM-yyyy");
        }

        public double GetOldBalance()
        {
            return OldBalance;
        }

        public double GetNewBalance()
        {
            return NewBalance;
        }

        public string GetDate()
        {
            return Date;
        }
    }
}
