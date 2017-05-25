using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculations.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly Calculator _calc = new Calculator();

        [TestMethod()]
        public void FactorialTest()
        {
            const int x = 5;
            var factorial = _calc.Factorial(x);
            const int expected = 120;
            Assert.AreEqual(expected, factorial);
        }

        [TestMethod()]
        public void FibonacciTest()
        {
            const int x = 10;
            var fibonacci = _calc.Fibonacci(x);
            const int expected = 55;
            Assert.AreEqual(expected,fibonacci);
        }
    }
}