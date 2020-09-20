using System;
using Xunit;
using Bank_Tech_Test_C;

namespace Bank_Tech_Test_C_Unit_Tests
{
    public class AccountTest
    {
        public Account account;

        public AccountTest()
        {
            account = new Account();
        }

        [Fact]
        public void BalanceStartsAt0()
        {
            Assert.Equal(0, account.balance);
        }

        [Fact]
        public void DepositIncreasesBalance()
        {
            account.Deposit(30);
            Assert.Equal(30, account.balance);
        }

    }
}
