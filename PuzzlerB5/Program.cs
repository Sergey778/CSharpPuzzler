using System;

namespace PuzzlerB5
{
    struct A
    {
        public readonly int a;

        public A(int a)
        {
            this.a = a;
            this = new A(a + 1);
        } 
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A(11);

            Console.WriteLine(a);
        }
    }
}