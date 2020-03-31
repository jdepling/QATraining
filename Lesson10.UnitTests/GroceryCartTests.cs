using System.Collections.Generic;
using FluentAssertions;
using Moq;
using Xunit;

namespace Lesson10.UnitTests
{
    public class GroceryCartTests
    {
        [Fact]
        public void Evaluate_ValidInput_CorrectBalance()
        {
            // Arrange
            Mock<IPrices> pricesMock = new Mock<IPrices>();
            pricesMock.Setup(p => p.CheckPrice(It.IsAny<Item>())).Returns(2); // This will make CheckPrice always return $2 ... Now we don't need to call the DB
            GroceryCart cart = new GroceryCart(pricesMock.Object);

            cart.LoadItem(Item.Bacon, 5);   // Should be $10
            cart.LoadItem(Item.Milk, 5);   // Should be $10
            cart.LoadItem(Item.Bread, 5); // Should be $10
            cart.LoadItem(Item.Eggs, 5); // Should be $10, Total should be $40
            var expected = 40;

            // Act
            var actual = cart.Evaluate();

            // Assert
            actual.Should().Be(expected);
        }

        [Fact]

        public void CheckCart_ValidInput_HasItem()
        {
            // Arrange
            Mock<IPrices> pricesMock = new Mock<IPrices>();
            GroceryCart cart = new GroceryCart(pricesMock.Object);
            cart.LoadItem(Item.Eggs, 4);
            var expected = new Dictionary<Item, double>();
            expected.Add(Item.Eggs, 4);

            // Act
            var actual = cart.CheckCart();

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
