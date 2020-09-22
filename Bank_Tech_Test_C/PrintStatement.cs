using System;
using System.Collections.Generic;

namespace Bank_Tech_Test_C
{
    public class PrintStatement
    {

        public PrintStatement()
        {
        }

        public static string Print(Interaction history)
        {
            string title = "date || credit || debit || balance";
            if(history.GetNewBalance() - history.GetOldBalance() > 0)
            {
                return title + "\n" + PrintDeposit(history);
            } else
            {
                return title + "\n" + PrintWithdrawal(history);
            }
        }

        private static string PrintDeposit(Interaction interaction)
        {
            return $"{interaction.GetDate()} || || {string.Format("{0:0.00}", (interaction.GetNewBalance() - interaction.GetOldBalance()))} || {string.Format("{0:0.00}", interaction.GetNewBalance())}";
        }

        private static string PrintWithdrawal(Interaction interaction)
        {
            return $"{interaction.GetDate()} || {string.Format("{0:0.00}", (-(interaction.GetNewBalance() - interaction.GetOldBalance())))} || || {string.Format("{0:0.00}", interaction.GetNewBalance())}";
        }
    }
}
