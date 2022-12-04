using System.Collections;
using System.IO;
namespace _2256._Minimum_Average_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Enumerable.Range(0, 100000).ToArray();
            //int[] nums = new int[] { 1 };


            var res = new Solution().MinimumAverageDifference(nums);
        }
    }

    public class Solution
    {
        public int MinimumAverageDifference(int[] nums)
        {
            long numsSum = 0;
            foreach (var n in nums) numsSum += n;

            var average = new List<int>();

            long left = 0;
            long right = 0;

            int index = 0;
            int minValue = int.MaxValue;

            int i = 0;
            while (i++ < nums.Length)
            {
                left += nums[i - 1];
                right = numsSum - left;

                long ave1 = left / i;
                long ave2 = right is 0 ? 0 : right / (nums.Length - i);

                int ave = (int)(ave1 - ave2);
                if (ave < 0) ave *= -1;

                if (ave < minValue)
                {
                    minValue = ave;
                    index = i - 1;
                }
            }

            return index;
        }
    }
}