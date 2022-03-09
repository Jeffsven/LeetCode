using System;
using System.Collections.Generic;
using System.Linq;


namespace _560._Subarray_Sum_Equals_K
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] nums = new int[] { 1,1,1};
            int k = 2;

            var res = new Solution().SubarraySum(nums, k);
        }
    }

    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            int max = 0;
            List<int> sum = new List<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                sum.Add(nums[i]);
                if (sum.Sum() == k)
                {
                    max = Math.Max(sum.Count, max);
                    sum.Clear();
                }
            }

            return max;
        }
    }
}
