using System;

namespace Training
{
    internal class Delegates
    {
        public static int MtdCall(string s)
        {
            return s.Length;
        }

        delegate int Del(string s);
        internal static void Run()
        {
            var d = new Del(MtdCall);
            int answer = d("123");

        }

       
    }
}