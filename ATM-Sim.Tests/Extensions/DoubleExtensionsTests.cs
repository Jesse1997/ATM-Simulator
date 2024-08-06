using ATM_Sim.Extensions;

namespace ATM_Sim.Tests.Extensions
{
    public class DoubleExtensionsTests
    {
        [Theory]
        [InlineData(0, "0,00")]
        [InlineData(1.1, "1,10")]
        [InlineData(-345.01, "-345,01")]
        public void EurosToString_ShouldConvertDoubleToStringInEuros(double input, string expected)
        {
            // Arrange

            // Act
            var result = input.EurosToString();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}