using System;
using Xunit;
using Bank_Tech_Test_C;

namespace Bank_Tech_Test_C_Unit_Tests
{
    public class InteractionTest
    {
        public Interaction interaction;

        public InteractionTest()
        {
            interaction = new Interaction(30, 10);
        }

        [Fact]
        public void StoresOldBalance()
        {
            Assert.Equal(10.00, interaction.GetOldBalance());
        }

        [Fact]
        public void SetsNewBalance()
        {
            Assert.Equal(40.00, interaction.GetNewBalance());
        }

        [Fact]
        public void StoresCreationDate()
        {
            Assert.Equal("22/09/2020", interaction.GetDate());
        }

    }
}
