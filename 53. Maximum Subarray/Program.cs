using System;
using System.Linq;

namespace _53._Maximum_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] input = new int[] { 1 };

            var res = new Solution().MaxSubArray(input);
        }
    }

    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length is 1) return nums[0];

            int maxvalue = nums.Max();

            for (int i = 0; i < nums.Length; i++)
            {
                maxvalue = Math.Max()
            }

            return maxvalue;
        }
    }
}
