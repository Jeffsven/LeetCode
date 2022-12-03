using System;
using System.Collections.Generic;
using System.Linq;

namespace _658._Find_K_Closest_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var arr = new int[] { 0, 0, 0, 1, 3, 5, 6, 7, 8, 8 };
            int k = 2;
            int x = 2;
            var res = new Solution().FindClosestElements(arr, k, x);
        }
    }

    public class Solution
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            List<Tuple<int, int>> ts = new List<Tuple<int, int>>();//1:diff, 2:index
            ts = arr.Select(z => new Tuple<int, int>(Math.Abs(z - x), Array.IndexOf(arr, z))).ToList();
            ts = ts.OrderBy(z => z.Item1).ToList();
            ts = ts.GetRange(0, k).ToList();

            List<int> res = ts.Select(z => arr[z.Item2]).OrderBy(z => z).ToList();
            return res;
        }
    }
}
