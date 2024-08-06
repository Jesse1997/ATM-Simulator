using ATM_Sim.Model;

namespace ATM_Sim.Tests
{
    public class IntExtensionsTests
    {
        [Fact]
        public void ShowScreen_ShouldShowScreenWithOptions()
        {
            // Arrange
            var atm = new Atm(new Account());
            using StringWriter sw = new ();
            Console.SetOut(sw);
            string expected =
            $"--------ATM--------\n" +
            $"|  0 - Exit       |\n" +
            $"|  1 - View Money |\n" +
            $"-------------------\n";

            // Act
            atm.ShowScreen();

            // Assert
            Assert.Equal(expected, sw.ToString());
        }

        [Fact]
        public void ShowMoney_NewlyCreatedAccount_ShouldShowZero()
        {
            // Arrange
            var atm = new Atm(new Account());
            using StringWriter sw = new();
            Console.SetOut(sw);
            string expected = "Current money: €0,00\n";

            // Act
            atm.ShowMoney();

            // Assert
            Assert.Equal(expected, sw.ToString());
        }
    }
}