using System;
namespace Bank_Tech_Test_C
{
    public class Interaction
    {
        public double OldBalance;
        public double NewBalance;
        public string Date;

        public Interaction(double value, double oldBalance)
        {
            OldBalance = oldBalance;
            NewBalance = OldBalance + value;
            Date = DateTime.Now.ToString("dd-MM-yyyy");
        }
    }
}
