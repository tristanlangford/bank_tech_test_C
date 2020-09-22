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
            return title + "\n" + $"{history.GetDate()} || || {string.Format("{0:0.00}", (history.GetNewBalance() - history.GetOldBalance()))} || {string.Format("{0:0.00}", history.GetNewBalance())}";
        }
    }
}
