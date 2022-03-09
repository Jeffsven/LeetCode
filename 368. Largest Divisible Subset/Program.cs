using System;
using System.Linq;
using System.Collections.Generic;

namespace _368._Largest_Divisible_Subset
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] nums = new int[] { 1, 2, 3, 4, 6, 24 };

            var res = new Solution().LargestDivisibleSubset(nums);
        }
    }

    public class Solution
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            List<int[]> res = new List<int[]>();

            foreach (int no in nums)
            {
                res.Add(nums.Where(x => x != no && (no % x is 0 || x % no is 0)).ToArray());
            }

            List<int> output = new List<int>();

            return new List<int>();
        }
    }
}
