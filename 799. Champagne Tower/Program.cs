using System;
using System.Linq;
using System.Collections.Generic;

namespace _799._Champagne_Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            int poured = 100000009;
            int query_row = 33;
            int query_glass = 17;

            var res = new Solution().ChampagneTower(poured, query_row, query_glass);
        }
    }

    public class Solution
    {
        public double ChampagneTower(int poured, int query_row, int query_glass)
        {
            var a = Enumerable.Range(0, poured).Select(x => Math.Pow(0.5, x)).ToList();

            return a[query_row] * query_glass;
        }
    }
}
