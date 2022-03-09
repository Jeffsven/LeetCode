using System;
using System.Linq;
using System.Collections.Generic;

namespace _392._Is_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string s = "leeeeetcode";
            string t = "";

            var res = new Solution().IsSubsequence(s, t);
        }
    }

    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            var trimmed_t = string.Join("", t.ToCharArray().Where(x => s.Contains(x)));

            return trimmed_t.Contains(s);
        }
    }
}
