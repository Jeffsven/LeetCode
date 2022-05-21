using System;
using System.Linq;
using System.Collections.Generic;

namespace _287._Find_the_Duplicate_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { };
            var res = new Solution().FindDuplicate(nums);
        }
    }

    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            var key = nums.GroupBy(x => x).Where(x => x.Count() > 1).First().Key;
            return key;
        }
    }
}
