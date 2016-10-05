using System.Linq;

namespace Calculations
{
    public class Calculator
    {
        public int Factorial(int i)
        {
            return Enumerable.Range(1, i).Aggregate((current, x) => current*x);
        }
    }
}
