using System;
using System.Collections.Generic;
using System.Linq;

namespace PuzzlerB7
{
    class C
    {
        static void Foo<T>(T e) where T : IEnumerable<(int u, int v)>, IEnumerable<(int x, int y)>
        {
            var x = e.First().x;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wow! This works");
        }
    }
}