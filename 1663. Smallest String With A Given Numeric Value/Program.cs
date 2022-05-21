using System;
using System.Diagnostics;

namespace _1663._Smallest_String_With_A_Given_Numeric_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int n = 0;
            int k = 0;

            var res = new Solution().GetSmallestString(n, k);
        }
    }

    public class Solution
    {
        char[] Alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public string GetSmallestString(int n, int k)
        {
            char[] output = new char[5];

            for (int i = 0; i < n; i++)
            {

            }

            return "";
        }
    }
}
