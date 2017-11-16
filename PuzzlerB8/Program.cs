using System;

namespace PuzzlerB8
{
    internal static class Program
    {

        private static int Foo(int a) => a + 1;

        private static Func<TIn, TOut> AsLambda<TIn, TOut>(Func<TIn, TOut> func) => func;
        
        static void Main(string[] args)
        {
            Console.WriteLine(AsLambda(Foo)(1));
        }
    }
}