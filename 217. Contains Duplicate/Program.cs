using System;
using System.Linq;
using System.Collections.Generic;

namespace _217._Contains_Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] nums = new int[] { 1, 2, 3, 4 };

            var res = new Solution().ContainsDuplicate(nums);
        }
    }


    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return nums.GroupBy(x => x).Where(x => x.Count() > 1).Count() != 0;
        }
    }
}
