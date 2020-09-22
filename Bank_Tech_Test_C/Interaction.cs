using System;
using ServiceLocator;
namespace Bank_Tech_Test_C
{
    public class Interaction : IInteraction
    {
        private readonly double OldBalance;

        private readonly double NewBalance;

        private readonly string Date;

        private readonly Func<DateTime> _DateTimeProvider;

        public Interaction(double value, double oldBalance, Func<DateTime> DateTimeProvider)
        {
            OldBalance = oldBalance;
            NewBalance = OldBalance + value;
            _DateTimeProvider = DateTimeProvider;
            Date = _DateTimeProvider().ToString("dd/MM/yyyy");
        }

        public double GetOldBalance()
        {
            return Math.Round(OldBalance, 2);
        }

        public double GetNewBalance()
        {
            return Math.Round(NewBalance, 2);
        }

        public string GetDate()
        {
            return Date;
        }
    }
}
