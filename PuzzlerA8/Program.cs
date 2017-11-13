using System;

namespace PuzzlerA8
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new string(new char[1]);
            var y = new string(new char[1]);

            Console.WriteLine(ReferenceEquals(x, y));
        }
    }
}