using FluentAssertions;
using Xunit;

namespace UnitTestingBasics.UnitTest
{
    public class QaClassToTestTests
    {
        [Fact]
        public void Purchase_PurchaseBurrito_ReturnsValidAmount()
        {
            // Arrange
            QaClassToTest helper = new QaClassToTest();
            double expected = 10.90;

            // Act
            double actual = helper.Purchase(2, Item.Burrito);

            // Assert
            actual.Should().Be(expected);
        }

        [Fact]
        public void AdrianneIsFullOfPizza_ThreeSlices_ReturnsTrue()
        {
            //Arrange
            QaClassToTest helper = new QaClassToTest();

            //Act
            bool actual = helper.AdrianneIsFullOfPizza(3);

            //Assert
            actual.Should().BeTrue();
        }

        [Fact]
        public void DecideWinner_ShotgunVsPistol_ShotgunWins()
        {
            //Arrange
            QaClassToTest helper = new QaClassToTest();

            //Act
            Weapon testWinner = helper.DecideWinner(Weapon.Pistol, helper.WeaponDictionary[Weapon.Pistol], Weapon.Shotgun, helper.WeaponDictionary[Weapon.Shotgun]);

            //Assert
            testWinner.Should().Be(Weapon.Shotgun);
        }

        [Fact]
        public void CowWrangle_SixCowboysForSevenDays_NoCowsLeft()
        {
            // Arrange
            QaClassToTest myThing = new QaClassToTest();

            // Act
            int actual = myThing.CowWrangle(100, 6, 7);

            // Assert
            actual.Should().Be(0);
        }

        [Fact]
        public void NickMethodToTest_ValidInput_ExpectedStringReturned()
        {
            // Arrange
            QaClassToTest nicksThing = new QaClassToTest();
            string expected = "Whatchu talkin' 'bout, Jimmy? This ain't my dad, this is a Rubix Cube!!! (throw it on the ground)";

            // Act
            string actual = nicksThing.NickMethodToTest("Jimmy", "Rubix Cube", 2);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

    }
}
