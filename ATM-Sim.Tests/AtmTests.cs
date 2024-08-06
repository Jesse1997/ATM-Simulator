using ATM_Sim.Model;

namespace ATM_Sim.Tests
{
    public class AtmTests
    {
        [Fact]
        public void ShowScreen_ShouldShowScreenWithOptions()
        {
            // Arrange
            var atm = new Atm();
            using StringWriter sw = new ();
            Console.SetOut(sw);
            string expected =
            $"--------ATM--------\n" +
            $"|  1 - View Money |\n" +
            $"-------------------\n";

            // Act
            atm.ShowScreen();

            // Assert
            Assert.Equal(expected, sw.ToString());
        }
    }
}