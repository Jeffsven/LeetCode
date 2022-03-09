using System;
using System.Linq;
using System.Collections.Generic;


namespace _228._Summary_Ranges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {-2147483648, -2147483647, 2147483647};
            var res = new Solution().SummaryRanges(nums);
        }
    }

    public class Solution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            List<List<int>> numlist = new List<List<int>>();
            List<int> twonum = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (twonum.Count is 0) twonum.Add(nums[i]);

                if (!nums.Contains(nums[i] + 1) || nums[i] is int.MaxValue)
                {
                    twonum.Add(nums[i]);
                    numlist.Add(twonum);
                    twonum = new List<int>();
                }
            }

            var s = numlist.Select(x => x[0].ToString() + (x[1] != x[0] ? $"->{x[1]}" : "")).ToList();

            return s;
        }
    }
}
