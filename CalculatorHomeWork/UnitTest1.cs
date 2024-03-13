using New;

namespace CalculatorHomeWork
{
    public class CalculatorNew
    {
        private readonly CalculatorFunction _calculator = new CalculatorFunction();

        [Fact]
        public void TestAdd()
        {
            int a = 5;
            int b = 3;
            int exeptedValue = 8;
            Assert.Equal(exeptedValue, _calculator.Add(a, b));
        }

        [Fact]
        public void TestSubtract()
        {
            Assert.Equal(2, _calculator.Subtract(5, 3));
            Assert.Equal(2, _calculator.Subtract(1, -1));
            Assert.Equal(0, _calculator.Subtract(0, 0));
        }

        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(9, 3, 3)]
        public void TestMultiply(int a, int b, int exeptedValue)
        {
            Assert.Equal(exeptedValue, _calculator.Multiply(a, b));
        }

        [Fact]
        public void TestDivide()
        {
            int a = 32;
            int b = 4;
            int exeptedValue = 8;
            int result = _calculator.Divide(a, b);
            Assert.Equal(exeptedValue, result);
        }
    }
}
