using System;
using Bank_Tech_Test_C;
using System.Collections.Generic;
using Xunit;
using Moq;

namespace Bank_Tech_Test_C_Unit_Tests
{
    public class PrintStatementTest
    {
        public Interaction MockInteraction1;
        public Interaction MockInteraction2;

        public PrintStatementTest()
        {
            MockInteraction1 = new Interaction(500, 0);
            MockInteraction2 = new Interaction(-500, 1000);
        }

        [Fact]
        public void ContainsTitle()
        {
            Assert.Contains("date || credit || debit || balance", PrintStatement.Print(MockInteraction1));
        }

        [Fact]
        public void PrintsSingleHistory()
        {
            Assert.Contains("22/09/2020 || || 500.00 || 500.00", PrintStatement.Print(MockInteraction1));
        }

        [Fact]
        public void CorrectFormatForWithdrawal()
        {
            Assert.Contains("22/09/2020 || 500.00 || || 500.00", PrintStatement.Print(MockInteraction2));
        }
    }

    
}
