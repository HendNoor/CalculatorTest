using CalculatorTest;
namespace CalculatorTests
{
    public class UnitTest1
    {
        Methods m = new Methods();

        [Fact]
        public void AddingTwoPositiveNumTest()
        {
            Assert.Equal(4, m.Addition(2, 2));
        }
        [Fact]
        public void AddingTwoNegtiveNumTest()
        {
            Assert.Equal(-4, m.Addition(-2, -2));
        }
        [Fact]
        public void AddingPositiveNumAndNegitiveNumTest()
        {
            Assert.Equal(0, m.Addition(2, -2));
        }
        [Fact]
        public void AdditionPositiveArrayTest()
        {
            var result = Methods.Addition(new int[] { 2, 2, 2 });
            Assert.Equal(6, result);
        }

        [Fact]
        public void SubtractingTwoPositiveNumTest()
        {
            Assert.Equal(0, m.Subtraction(2, 2));
        }
        [Fact]
        public void SubtractingTwoNegitiveNumTest()
        {
            Assert.Equal(0, m.Subtraction(-2, -2));
        }

        [Fact]
        public void Subtracting1stNumPositiveAnd2ndNegitiveNumTest()
        {
            Assert.Equal(4, m.Subtraction(2, -2));
        }
        [Fact]
        public void Subtracting1stNumNegitiveAnd2ndPositiveNumTest()
        {
            Assert.Equal(-4, m.Subtraction(-2, 2));
        }
        [Fact]
        public void SubtractionPositiveArrayTest()
        {
            var result = Methods.Subtraction(new int[] { 10, 2, 2 });
            Assert.Equal(6, result);
        }

        [Fact]
        public void MultiplicationTest()
        {
            Assert.Equal(4, m.Multiplication(2, 2));
        }
        [Fact]
        public void DivisionTest()
        {
            Assert.Equal(1, m.Division(2, 2));
        }
        [Fact]
        public void DividByZeroFirstNumTest()
        {
            Assert.Equal(0, m.Division(0, 1));
            Assert.IsNotType<decimal>(m.Division(10, 0));

        }
    }
}