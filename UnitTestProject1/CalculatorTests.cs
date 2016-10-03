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
            var fact = calc.Factorial(5);
            Assert.AreEqual(120,fact);
        }
    }
}