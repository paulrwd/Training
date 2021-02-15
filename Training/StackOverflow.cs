using System;

namespace Training
{
    internal class StackOverflow
    {
        internal static void Run()
        {
            Foo(0);
        }

        private static void Foo( int i)
        {
            Console.WriteLine(i);
            //if(i >=3)
            //{
            //    return;
            //}
            i++;
            Foo(i);
        }
    }
}