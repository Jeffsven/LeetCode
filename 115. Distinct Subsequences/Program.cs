using System;
using System.Collections.Generic;
using System.Linq;

namespace _115._Distinct_Subsequences
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "babgbag";
            string t = "bag";

            int result = new Solution().NumDistinct(s, t);

        }
    }

    public class Solution
    {
        public int NumDistinct(string s, string t)
        {
            List<int> idx = new List<int>();

            var a = s.ToCharArray();

            var c1 = s.ToCharArray().ToList();
            var c2 = t.ToCharArray().ToList();

            for (int i = 0; i < c1.Count; i++)
            {
                if (c1[i] != c2[i])
                {
                    if (!idx.Contains(i))
                    {
                        c1.RemoveAt(i);
                        idx.Add(i);
                        i = 0;
                    }
                }
            }
            return idx.Count;
        }
    }
}
