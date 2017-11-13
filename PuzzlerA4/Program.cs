using System;

namespace PuzzlerA4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BillionDollarProblem(int.MinValue));
        }

        static int BillionDollarProblem(int a)
        {
            return a == 1000000 ? a : BillionDollarProblem(a + 1);
        }
    }
}