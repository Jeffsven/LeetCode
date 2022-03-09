using System;
using System.Linq;
using System.Collections.Generic;

namespace _567._Permutation_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string s1 = "adq";
            string s2 = "uhuadqadqdaqn";

            var res = new Solution().CheckInclusion(s1, s2);

        }
    }

    public class Solution
    {
        public bool CheckInclusion(string s1, string s2)
        {
            var p = string.Join("", s1.Reverse());

            var res = s2.Contains(p);
            return res;
        }
    }
}
