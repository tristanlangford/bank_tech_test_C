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

        public PrintStatementTest()
        {
            MockInteraction1 = new Interaction(500, 0);
        }

        [Fact]
        public void ContainsTitle()
        {
            Assert.Contains("date || credit || debit || balance", PrintStatement.Print(MockInteraction1));
        }

        [Fact]
        public void PrintsSingleHistory()
        {
            Assert.Contains("14/01/2012 || || 500.00 || 500.00", PrintStatement.Print());
        }

    }

    
}
