using System;
using System.Linq;
using System.Collections.Generic;


namespace _338._Counting_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int input = 2;
            var res = new Solution().CountBits(input);
        }
    }
    public class Solution
    {
        public int[] CountBits(int n)
        {
            int[] res = new int[n + 1];

            for(int i = 0; i < n + 1; i++)
            {
                var bit = Convert.ToString(i, 2);
                var no1 = bit.ToCharArray().Where(x => x is '1').Count();
                res[i] = no1;
            }

            return res;
        }
    }
}
