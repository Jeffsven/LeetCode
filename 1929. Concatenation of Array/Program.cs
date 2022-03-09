using System;
using System.Linq;


namespace _1929._Concatenation_of_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var res = new Solution().GetConcatenation(new int[] { 1, 2, 3 });
        }
    }

    public class Solution
    {
        public int[] GetConcatenation(int[] nums)
        {
            var clonednums = (int[])nums.Clone();

            var res = nums.Concat(clonednums).ToArray();

            return res;
        }
    }
}
