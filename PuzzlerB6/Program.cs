using System;

namespace PuzzlerB6
{
    public struct Flag // NB: struct
    {
        bool value;

        public Flag(ref Flag byref)
        {
            this.value = true;
            Console.WriteLine(byref.value);
        }

        public static void Main()
        {
            var local = default(Flag);
            var captured = default(Flag);
            local = new Flag(ref local);
            captured = new Flag(ref captured);
            return;
            Func<Flag> a = () => captured; // just capture, do not do anything
        }
    }
}