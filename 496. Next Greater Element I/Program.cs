using System;
using System.Collections.Generic;
using System.Linq;

namespace _496._Next_Greater_Element_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] nums1 = new int[] { 1, 3, 5, 2, 4 };
            int[] nums2 = new int[] { 6, 5, 4, 3, 2, 1, 7 };

            var res = new Solution().NextGreaterElement(nums1, nums2);
        }
    }

    public class Solution
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var nums1list = nums1.ToList();
            var nums2list = nums2.ToList();

            var res = new List<int>();

            foreach (int num in nums1list)
            {
                var a = nums2list.FindIndex(x => x == num);
                if (a + 1 >= nums2list.Count) res.Add(-1);
                else
                {
                    var s = nums2list.IndexOf(num);
                    var greaterno = nums2list.GetRange(s, nums2list.Count - s).Find(x => x > num);
                    res.Add(greaterno > num ? greaterno : -1);
                }
            }

            return res.ToArray();
        }
    }
}
