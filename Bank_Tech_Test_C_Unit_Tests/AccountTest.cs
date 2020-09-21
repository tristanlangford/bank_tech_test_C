using Moq;
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

        [Fact]
        public void DepositWithMinusErrors()
        {
            var err = Assert.Throws<InvalidOperationException>(() => account.Deposit(-10));
            Assert.Equal("Cannot deposit less than 0.01", err.Message);
        }

        [Fact]
        public void DepositAddsToInteractionList()
        {
            account.Deposit(30);
            Assert.IsType<Interaction>(account.history[0]);
        }

        [Fact]
        public void WithdrawDecreasesBalance()
        {
            account.Withdraw(30);
            Assert.Equal(-30, account.balance);
        }

        [Fact]
        public void WithdrawWithMinusErrors()
        {
            var err = Assert.Throws<InvalidOperationException>(() => account.Withdraw(-30));
            Assert.Equal("Cannot withdraw less than 0.01", err.Message);
        }

        [Fact]
        public void WithdrawAddsToInteractionList()
        {
            account.Withdraw(30);
            Assert.IsType<Interaction>(account.history[0]);
        }

    }
}
