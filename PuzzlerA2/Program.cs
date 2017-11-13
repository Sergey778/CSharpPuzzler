using System;
using System.Collections.Generic;
using System.Linq;

namespace PuzzlerA2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 7, 2, 5, 7, 7, 7, 7 };
            var result = numbers.Skip(2).Take(3).Sum();
            var y = numbers.GroupBy(x => x).Select(x =>
            {
                result += x.Key;
                return x.Key;
            });

            Console.WriteLine(result);
        }
    }
}