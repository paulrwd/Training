using System;
using System.Diagnostics;

namespace Training
{
    internal class Param_IN
    {

        struct Point
        {
            public decimal a;
            public decimal b;
            public decimal c;
            public decimal x;
            public decimal y;
            public decimal z;
        }

        static void Foo(Point value)
        {

        }
        static void Bar(in Point value)
        {

        }

        internal static void Run()
        {
            Point a = new Point();
          

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Foo(a);
            }
            sw.Stop();
            Console.WriteLine($"Foo {sw.ElapsedMilliseconds}");
            sw.Restart();
            for (int i = 0; i < int.MaxValue; i++)
            {
                Bar(a);
            }
            sw.Stop();
            Console.WriteLine($"Bar {sw.ElapsedMilliseconds}");
        }
    }
}