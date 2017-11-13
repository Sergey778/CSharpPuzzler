using System;

namespace PuzzlerA8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new string(new char[0]);
            var y = new string(new char[0]);

            Console.WriteLine(ReferenceEquals(x, y));
        }
    }
}