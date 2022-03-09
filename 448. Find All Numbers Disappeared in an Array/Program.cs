using System;
using System.Linq;
using System.Collections.Generic;


namespace _448._Find_All_Numbers_Disappeared_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };

            var res = new Solution2().FindDisappearedNumbers(list);
        }
    }

    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> disappearedNo = new List<int>();

            int start = 0;
            while (start++ < nums.Length)
            {
                if (!nums.Contains(start)) disappearedNo.Add(start);
            }

            return disappearedNo;
        }
    }
    public class Solution2
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var s = Enumerable.Range(1, nums.Length).ToList();
            nums = nums.Distinct().ToArray();
            s.RemoveAll(x => nums.Contains(x));

            return s;
        }
    }
}
