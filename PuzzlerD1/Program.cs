using System;
using System.Collections.Generic;
using System.Linq;

namespace PuzzlerD1
{
    public struct Test
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test { Name = "Hello" };
            var list = new List<Test>();
            list.Add(test);
            test.Name = "World";
            Console.WriteLine(list.First().Name);
        }
    }
}
