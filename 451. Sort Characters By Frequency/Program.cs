using System;
using System.Linq;
using System.Collections.Generic;

namespace _451._Sort_Characters_By_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Aabba";
            var res = new Solution().FrequencySort(input);
        }
    }

    public class Solution
    {
        public string FrequencySort(string s)
        {
            return string.Join("", s.GroupBy(x => x).OrderByDescending(x => x.Count()).SelectMany(x => x.ToArray()).ToArray());
        }
    }
}
