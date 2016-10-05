using Microsoft.VisualStudio.TestTools.UnitTesting;


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