using System;

namespace PuzzlerA6
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = 12.8;
            var i1 = Convert.ToInt32(d);
            var i2 = (int)d;
            Console.WriteLine(i1 == i2);
        }
    }
}