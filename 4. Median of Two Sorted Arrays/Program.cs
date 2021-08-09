using System;

namespace _4._Median_of_Two_Sorted_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1,2,3,5 };
            int[] arr2 = new int[] { 4,7,8,6 };


            double median = new Solution().FindMedianSortedArrays(arr1, arr2);

            Console.WriteLine(string.Join(',', arr1));
            Console.WriteLine(string.Join(',', arr2));
            Console.Write(median);
        }
    }


    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int length = nums1.Length + nums2.Length;
            int[] arr = new int[length];

            int[] currentIdx = new int[2] { 0, 0 };

            int value;

            for (int i = 0; i < length; i++)
            {
                if (currentIdx[0] >= nums1.Length)
                {
                    value = nums2[currentIdx[1]++];
                }
                else if (currentIdx[1] >= nums2.Length)
                {
                    value = nums1[currentIdx[0]++];
                }
                else
                {
                    value = Math.Min(nums1[currentIdx[0]], nums2[currentIdx[1]]);
                    if (value == nums1[currentIdx[0]]) currentIdx[0]++;
                    else currentIdx[1]++;
                }

                arr[i] = value;
            }





            int arrlength = arr.Length;
            bool even = arrlength % 2 is 0;

            if (even)
            {
                int m = arrlength / 2;
                int bm = m - 1;

                return (double)(arr[m] + arr[bm]) / 2;
            }
            else
            {
                int m = (arrlength / 2);
                return arr[m];
            }
        }
    }
}
