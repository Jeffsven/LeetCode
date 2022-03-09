using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _1015._Smallest_Integer_Divisible_by_K
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = new Solution().SmallestRepunitDivByK(5);
        }
    }

    public class Solution
    {
        public int SmallestRepunitDivByK(int k)
        {
            if (k % 2 is 0) return -1;
            if (k % 5 is 0) return -1;

            BigInteger n = 1;
            BigInteger m = 10;

            while (true)
            {
                if (n % k == 0) return n.ToString().Length;
                n += m;
                m *= 10;
            }
        }
    }
}
