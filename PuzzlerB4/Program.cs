using System;

namespace PuzzlerB4
{
    class Program
    {
        public static void Main()
        {
            Foo<int>();
        }
	
        static void Foo<T>() where T : new() 
        { 
            var t = new T(); 
            Console.WriteLine(t.ToString()); 
            Console.WriteLine(t.GetHashCode()); 
            Console.WriteLine(t.Equals(t)); 
            Console.WriteLine(t.GetType()); 
        }
    }
}