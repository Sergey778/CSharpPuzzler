using System;

namespace PuzzlerA3
{
    class Base
    {
        public virtual void Foo(int x)
        {
            Console.WriteLine("Base.Foo(int)");
        }
    }

    class Derived : Base
    {
        public override void Foo(int x)
        {
            Console.WriteLine("Derived.Foo(int)");
        }

        public void Foo(object o, int y = 1)
        {
            Console.WriteLine("Derived.Foo(object)");
        }
    }

    class Program
    {
        static void Main()
        {
            var d = new Derived();
            var i = 10;
            d.Foo(i);
        }
    }
}