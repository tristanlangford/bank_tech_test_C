using System;
using System.Collections.Generic;

namespace Bank_Tech_Test_C
{
    public class PrintStatement
    {
        private const string Title = "date || credit || debit || balance";

        public static string Print(List<IInteraction> history)
        {
            string statement = Title;
            foreach(IInteraction i in history)
            {
                if (GetValue(i) > 0)
                {
                    statement += "\n" + PrintDeposit(i);
                }
                else
                {
                    statement += "\n" + PrintWithdrawal(i);
                }
            }
            return statement;
        }

        private static double GetValue(IInteraction interaction)
        {
            return interaction.GetNewBalance() - interaction.GetOldBalance();
        }

        private static string PrintDeposit(IInteraction interaction)
        {
            return $"{interaction.GetDate()} || || {string.Format("{0:0.00}", (GetValue(interaction)))} || {string.Format("{0:0.00}", interaction.GetNewBalance())}";
        }

        private static string PrintWithdrawal(IInteraction interaction)
        {
            return $"{interaction.GetDate()} || {string.Format("{0:0.00}", -GetValue(interaction))} || || {string.Format("{0:0.00}", interaction.GetNewBalance())}";
        }
    }
}
