using System;
using System.Linq;
using System.Collections.Generic;

namespace _260._Single_Number_III
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] input = new int[] { };

            var res = new Solution().SingleNumber(input);
        }

        public class Solution
        {
            public int[] SingleNumber(int[] nums)
            {
                var res = nums.GroupBy(x => x).Where(x => x.Count() is 1).Select(x => x.Key).ToArray();
                return res;
            }
        }
    }
}
