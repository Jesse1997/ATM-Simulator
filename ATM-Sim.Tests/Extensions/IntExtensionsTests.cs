using ATM_Sim.Helpers;

namespace ATM_Sim.Tests.Extensions
{
    public class IntExtensionsTests
    {
        [Theory]
        [InlineData(0, 0.00)]
        [InlineData(115, 1.15)]
        [InlineData(-34501, -345.01)]
        public void ConvertCentsToEuros_ShouldConvertIntInCentsToDoubleInEuros(int input, double expected)
        {
            // Arrange

            // Act
            var result = input.ConvertCentsToEuros();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}