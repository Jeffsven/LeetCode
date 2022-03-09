using System;
using System.Linq;
using System.Collections.Generic;

namespace _75._Sort_Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 0, 1 };
            new Solution().SortColors(input);
        }
    }

    public class Solution
    {
        public void SortColors(int[] nums)
        {
            var res = nums.GroupBy(x => x).OrderBy(x => x.Key).SelectMany(x => x.ToArray()).ToList();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = res[i];
            }
        }
    }
}
