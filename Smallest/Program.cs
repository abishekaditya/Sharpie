using System;
using System.Collections.Generic;

namespace Smallest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 5, 0, 7 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);
        }

    public static List<int> GetSmallests(List<int> list, int count)
    {
        var smallests = new List<int>();
            if (count <= list.Count)
            {
                while (smallests.Count < count)
                {
                    var min = GetSmallest(list);
                    smallests.Add(min);
                    list.Remove(min);
                }
            }
            else
            {
                Console.WriteLine("List has too few a value");
            }
        return smallests;
    }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
