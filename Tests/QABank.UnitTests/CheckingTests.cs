using FluentAssertions;
using Xunit;

namespace QABank.UnitTests
{
    public class CheckingTests
    {
        /// <summary>
        /// Tests to make sure that making a deposit will affect the balance in an expected way
        /// </summary>
        [Fact]
        public void Deposit_ValidInput_AddsToBalance()
        {
            // Arrange
            var testChecking = new Checking("Test Checking Account");

            // Act
            testChecking.Deposit(1000);

            // Assert
            testChecking.Balance.Should().Be(1000);
        }

        /// <summary>
        /// Tests to make sure that making a deposit will affect the balance in an expected way
        /// </summary>
        [Fact]
        public void Deposit_InvalidInput_DoesNothing()
        {
            // Arrange
            var testChecking = new Checking("Test Checking Account");
            testChecking.Deposit(1000);

            // Act
            testChecking.Deposit(-100);

            // Assert
            testChecking.Balance.Should().Be(1000);
        }

        /// <summary>
        /// Tests the withdrawing functionality using a "Theory"
        /// This will make it so we can write one test for more than one scenario --> Save time!
        /// </summary>
        [Theory]
        [InlineData(1000, 100, 900)]
        [InlineData(1000,-100, 1000)]
        public void Withdraw_GoodAndBadInput_SubtractsFromBalanceIfValid(double originalAmount, double withdrawAmount, double expectedAmount)
        {
            // Arrange
            var test = new Checking("test");
            test.Deposit(originalAmount);

            // Act
            test.Withdraw(withdrawAmount);

            // Assert
            test.Balance.Should().Be(expectedAmount);
        }
    }
}
