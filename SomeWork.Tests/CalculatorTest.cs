using UnitTestExample;
using Xunit;

namespace SomeWork.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_ShouldCalculate()
        {
            // Expected
            double expected = 13;

            // Actual
            double actual = Calculator.Add(5, 8);

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// It takes arguments.
        /// </summary>
        /// <param name="x">arg1.</param>
        /// <param name="y">arg2.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(5, 4, 9)]
        [InlineData(5.25, 12, 17.25)]
        public void Add_ShouldCalculate2(double x, double y, double expected)
        {
            // Expected

            // Actual
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
