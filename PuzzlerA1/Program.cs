using System;
using System.Collections.Generic;

namespace PuzzlerA1
{
    internal static class Program
    {
        class Foo<T>
        {
            public static int Bar;
        }
        
        public static void Main()
        {
            Foo<int>.Bar++;
            Console.WriteLine(Foo<double>.Bar);
        }
    }
}