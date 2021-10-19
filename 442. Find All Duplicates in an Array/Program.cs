using System;
using System.Collections.Generic;
using System.Linq;

namespace _442._Find_All_Duplicates_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] inputs = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };

            var a = new Solution().FindDuplicates(inputs);
            var b = new Solution2().FindDuplicates(inputs);

        }
    }


    public class Solution
    {
        // one line
        public IList<int> FindDuplicates(int[] nums)
        {
            return nums.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key).ToArray();
        }
    }

    public class Solution2
    {
        //space + menory complexity
        public IList<int> FindDuplicates(int[] nums)
        {
            return null;
        }
    }
}
