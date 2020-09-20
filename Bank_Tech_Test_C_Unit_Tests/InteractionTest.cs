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
            Assert.Equal(10, interaction.OldBalance);
        }

        [Fact]
        public void SetsNewBalance()
        {
            Assert.Equal(40, interaction.NewBalance);
        }

    }
}
