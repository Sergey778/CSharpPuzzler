using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace PuzzlerA5
{
    class Program
    {
        static void Main(string[] args)
        {
            var actions = new List<Action>();

            foreach (var i in Enumerable.Range(0, 5))
                actions.Add(() => Console.WriteLine(i));
		
            foreach (var act in actions)
                act();
        }
    }
}