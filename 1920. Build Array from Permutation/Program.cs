using System;

namespace _1920._Build_Array_from_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int[] BuildArray(int[] nums)
        {
            int[] res = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = nums[nums[i]];
            }

            return res;
        }
    }
}
