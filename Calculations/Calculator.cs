using System.Linq;

namespace Calculations
{
    public class Calculator
    {
        public int Factorial(int i)
        {
            return Enumerable.Range(1, i).Aggregate((current, x) => current*x);
        }

        public int Fibonacci(int num)
        {
            int a = 0, b = 1;
            for (var i = 0; i < num; i += 1)
            {
                var x = a + b;
                a = b;
                b = x;
            }
            return a;
        }
    }
}
