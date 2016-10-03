using System.Linq;

namespace Calculations
{
    public class Calculator
    {
        public int Factorial(int i)
        {
            var ans = 1;
            foreach (var x in Enumerable.Range(1,i))
            {
                ans *= x;
            }
            return ans;
        }
    }
}
