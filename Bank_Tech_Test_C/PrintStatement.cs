using System;
using System.Collections.Generic;

namespace Bank_Tech_Test_C
{
    public class PrintStatement
    {

        public PrintStatement()
        {
        }

        public static string Print(List<Interaction> history)
        {
            string statement = "date || credit || debit || balance";
            foreach(Interaction i in history)
            {
                if (i.GetNewBalance() - i.GetOldBalance() > 0)
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
