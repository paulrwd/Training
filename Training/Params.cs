using System;

namespace Training
{
    internal class Params
    {
        public static int Sum(params int[] parameters)
        {
            int result = 0;
            for(int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }

            return result;

        }
        delegate int Del(int[] p);
        internal static void Run()
        {
            int res = Sum(3,6,7,78);



            

            Console.WriteLine(res);
        }
    }
}