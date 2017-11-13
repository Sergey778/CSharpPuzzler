using System;

namespace PuzzlerB3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            int Foo()
            {
                a = a + 42;
                return 1;
            }
            a += Foo();
            Console.WriteLine(a);
        }
    }
}