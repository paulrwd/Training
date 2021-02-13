using System;

namespace Training
{
    internal class BuzzFuzz
    {
        internal static void Run()
        {
            string tLn = Console.ReadLine();
            int t = int.Parse(tLn);
            for (int i = 1; i < t; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("fuzz");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fuzzbuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
            //
        }
    }
}