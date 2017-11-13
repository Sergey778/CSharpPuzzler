using System;
using System.Collections.Generic;
using System.Linq;

namespace PuzzlerB2
{
    class Program
    {
        public static IEnumerable<int> GetSmallNumbers()
        {
            yield return 1;
            throw new Exception();
            yield return 2;
        }
        
        static void Main()
        {
            var numbers = GetSmallNumbers();
            var evenNumbers = numbers.Select(n => n * 2);
            Console.WriteLine(evenNumbers.FirstOrDefault());
        }
    }
}