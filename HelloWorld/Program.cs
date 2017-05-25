using System;

namespace HelloWorld
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var len = args.Length;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;

            switch (len)
            {
                case 0:
                    Console.WriteLine("Hello World");
                    break;
                case 1:
                    Console.WriteLine($"Hello {args[0]}");
                    break;
                default:
                    Console.WriteLine("Incorrect parameters");
                    break;
            }
        }
    }
}