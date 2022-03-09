using System;
using System.Linq;
using System.Collections.Generic;

namespace _1200._Minimum_Absolute_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] input = new int[] { 1, 2, 3, 4, 5 };
            var a = new Solution().MinimumAbsDifference(input);
        }
    }

    public class Solution
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            List<IList<int>> vs = new List<IList<int>>();

            var arrlist = arr.OrderBy(x => x).ToList();

            int max = int.MaxValue;

            for (int i = 0; i < arrlist.Count - 1; i++)
            {
                int diff = arrlist[i + 1] - arrlist[i];
                if (diff < max)
                {
                    max = diff;
                    vs.Clear();
                    vs.Add(new List<int>() { arrlist[i], arrlist[i + 1] });
                }
                else if (diff == max)
                {
                    vs.Add(new List<int>() { arrlist[i], arrlist[i + 1] });
                }
            }
            return vs;
        }
    }
}
