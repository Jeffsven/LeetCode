using System;
using System.Linq;
using System.Collections.Generic;

namespace _88._Merge_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] n1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] n2 = new int[] { 2, 5, 6 };

            new Solution().Merge(n1, 3, n2, 3);
        }
    }

    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Copy(nums2, 0, nums1, m, n);
            nums1.OrderBy(x => x).ToArray().CopyTo(nums1, 0);
        }
    }
}
