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
        public List<Interaction> history;

        public PrintStatementTest()
        {
            MockInteraction1 = new Interaction(500, 0, () => new DateTime(2018, 04, 22));
            MockInteraction2 = new Interaction(-500, 1000, () => new DateTime(2020, 09, 22));
            history = new List<Interaction> { MockInteraction1, MockInteraction2 };
        }

        [Fact]
        public void ContainsTitle()
        {
            Assert.Contains("date || credit || debit || balance", PrintStatement.Print(history));
        }

        [Fact]
        public void PrintsSingleHistory()
        {
            Assert.Contains("22/04/2018 || || 500.00 || 500.00", PrintStatement.Print(history));
        }

        [Fact]
        public void CorrectFormatForWithdrawal()
        {
            Assert.Contains("22/09/2020 || 500.00 || || 500.00", PrintStatement.Print(history));
        }

        [Fact]
        public void DealsWithList()
        {
            Assert.Contains("22/04/2018 || || 500.00 || 500.00", PrintStatement.Print(history));
            Assert.Contains("22/09/2020 || 500.00 || || 500.00", PrintStatement.Print(history));
        }

    }

    
}
