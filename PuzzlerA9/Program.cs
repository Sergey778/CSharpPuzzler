using System;

namespace PuzzlerA9
{
    class Foo
    {
        static Foo()
        {
            Console.WriteLine("Foo");
        }
    }

    class Bar
    {
        static int i = Init();
    
        static int Init()
        {
            Console.WriteLine("Bar");
            return 0;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Foo f = new Foo();
            Bar b = new Bar();
        }
    }
}