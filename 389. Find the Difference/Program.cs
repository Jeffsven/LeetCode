using System;
using System.Linq;
using System.Collections.Generic;


namespace _389._Find_the_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string s = "ae";
            string t = "aea";

            var c = new Solution().FindTheDifference(s,t);
        }
    }

    public class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            var c1 = s.OrderBy(x => x).ToArray();
            var c2 = t.OrderBy(x => x).ToArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (c1[i] != c2[i]) return c2[i];
            }

            return c2[s.Length];
        }
    }
}
