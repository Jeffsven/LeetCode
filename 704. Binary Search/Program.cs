using System;
using System.Linq;


namespace _704._Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { -1, 0, 3, 5, 9, 12 };
            int target = 2;

            var res = new Solution().Search(input, target);
        }

        public class Solution
        {
            public int Search(int[] nums, int target)
            {
                return nums.ToList().IndexOf(target);
                //if (!nums.Contains(target)) return -1;

                //int idx = -1;

                //foreach (var no in nums)
                //{
                //    idx++;
                //    if (target == no) break;
                //}

                //return idx;
            }
        }
    }
}
