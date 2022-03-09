using System;
using System.Linq;
using System.Collections.Generic;


namespace _18._4Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] arr = new int[] { 1, 0, -1, 0, -2, 2, 2 };

            var res = new Solution().FourSum(arr, 3);
        }
    }

    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            List<int> numslist = new List<int>();
            numslist = nums.Where(x => x < nums.Length).OrderBy(x => x).ToList();

            for(int i = 0; i < nums.Length - 4; i++)
            {

            }


            return null;

        }
    }
}
