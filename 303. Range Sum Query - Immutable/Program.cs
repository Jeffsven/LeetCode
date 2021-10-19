using System;
using System.Linq;
using System.Collections.Generic;

namespace _303._Range_Sum_Query___Immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            NumArray2 num = new NumArray2(new int[] { 0, 1, 2, 3, 4 });

            Console.WriteLine("Hello World!");
        }
    }


    public class NumArray
    {
        List<int> Nums;
        public NumArray(int[] nums)
        {
            Nums = nums.ToList();
        }

        public int SumRange(int left, int right)
        {
            return Nums.GetRange(left, right - left + 1).Sum();
        }
    }


    public class NumArray2
    {
        int[] NumsSum;
        public NumArray2(int[] nums)
        {
            NumsSum = new int[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                NumsSum[i + 1] = nums[i] + NumsSum[i];
            }
        }

        public int SumRange(int left, int right)
        {
            return NumsSum[right + 1] - NumsSum[left];
        }
    }

    /**
     * Your NumArray object will be instantiated and called as such:
     * NumArray obj = new NumArray(nums);
     * int param_1 = obj.SumRange(left,right);
     */
}
