using System;

namespace _1._Two_Sum
{
    class Program
    {
        //https://leetcode.com/problems/two-sum/

        static void Main(string[] args)
        {
            var problem = new int[2] { 3, 3 };
            var result = TwoSum(problem, 6);

            Console.WriteLine(string.Join(',', problem));
            Console.WriteLine(string.Join(',', result));
        }

        static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i <= nums.Length; i++)
            {
                int compareIdx = i;

                while (++compareIdx < nums.Length)
                {
                    if (nums[i] + nums[compareIdx] == target)
                    {
                        return new int[2] { i, compareIdx };
                    }
                }
            }
            return new int[2] { 0, 0 };
        }

    }
}
