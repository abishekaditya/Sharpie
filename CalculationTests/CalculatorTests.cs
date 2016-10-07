using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Tests
{
    [TestClass()]
    public class CalculatorTests
    {

        [TestMethod()]
        public void FactorialTest()
        {
            var calc = new Calculator();
            const int x = 5;
            var factorial = calc.Factorial(x);
            const int expected = 120;
            Assert.AreEqual(expected, factorial);
        }

        [TestMethod()]
        public void FibonacciTest()
        {
            var calc = new Calculator();
            const int x = 10;
            var fibonacci = calc.Fibonacci(x);
            const int expected = 55;
            Assert.AreEqual(expected,fibonacci);
        }
    }
}