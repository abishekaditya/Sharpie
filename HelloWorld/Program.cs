using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var len = args.Length;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;

            if (len == 0 )
            {
                Console.WriteLine("Hello World");
            }
            else if (len == 1)
            {
                Console.WriteLine("Hello {0}", args[0]);
            }
            else
            {
                Console.WriteLine("Incorrect parameters");
            }        }
    }
}
