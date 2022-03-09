using System;
using System.Linq;
using System.Collections.Generic;

namespace _136._Single_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] nums = new int[] { 4, 1, 2, 1, 2 };

            var res = new Solution().SingleNumber(nums);
        }
    }

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            return nums.GroupBy(x => x).Where(x => x.Count() is 1).First().Key;
        }
    }
}
