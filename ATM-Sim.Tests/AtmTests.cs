using ATM_Sim.Model;

namespace ATM_Sim.Tests
{
    public class AtmTests
    {
        [Fact]
        public void ShowScreen_ShouldShowScreenWithOptions()
        {
            // Arrange
            var atm = new Atm(new Account());
            using StringWriter sw = new ();
            Console.SetOut(sw);
            string expected =
            $"---------ATM----------\n" +
            $"|  0 - Exit          |\n" +
            $"|  1 - View Money    |\n" +
            $"|  2 - Deposit Money |\n" +
            $"-------------------\n";

            // Act
            atm.ShowScreen();

            // Assert
            Assert.Equal(expected, sw.ToString());
        }

        [Fact]
        public void ReceiveInput_UserChoosesZero_ShouldShowGoodbye()
        {
            // Arrange
            var atm = new Atm(new Account());
            using StringWriter sw = new();
            Console.SetOut(sw);
            string expected = "Have a nice day!\n";

            // Act
            atm.ReceiveInput(0);

            // Assert
            Assert.Equal(expected, sw.ToString());
        }

        [Fact]
        public void ReceiveInput_UserChoosesOne_ShouldShowCurrentMoney()
        {
            // Arrange
            var atm = new Atm(new Account());
            using StringWriter sw = new();
            Console.SetOut(sw);
            string expected = "Current money: €0,00\n";

            // Act
            atm.ReceiveInput(1);

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

        [Theory]
        [InlineData(1, 100)]
        [InlineData(0.11, 11)]
        [InlineData(345.01, 34501)]
        public void DepositMoney_ToNewlyCreatedAccount_ShouldAddMoneyToAccount(double input, int expected)
        {
            // Arrange
            var account = new Account();
            var atm = new Atm(account);
            using StringWriter sw = new();
            Console.SetOut(sw);

            // Act
            atm.DepositMoney(input);

            // Assert
            Assert.Equal(expected, account.GetMoney());
        }
    }
}