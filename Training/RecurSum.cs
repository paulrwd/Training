using System;

namespace Training
{
    internal class RecurSum
    {
        static int Foo(int value)
        {
            if (value < 10)
                return value;
            int digit = value % 10;

            int nextValue = value / 10;

            return digit + Foo(nextValue);
        }
        internal static void Run()
        {
            int myValue = 561;

            Foo(myValue);
        }
    }
}