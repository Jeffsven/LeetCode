using System;
using System.Linq;
using System.Collections.Generic;

namespace _154._Find_Minimum_in_Rotated_Sorted_Array_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { };
            var res = new Solution().FindMin(nums);
        }
    }

    public class Solution
    {
        public int FindMin(int[] nums)
        {
            return nums.Min();
        }
    }
}
