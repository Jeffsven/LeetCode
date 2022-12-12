using System.Collections.Generic;

namespace _6258._Longest_Square_Streak_in_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().LongestSquareStreak(new int[] { 10, 2, 13, 16, 8, 9, 13 }));
        }
    }
    public class Solution
    {
        public int LongestSquareStreak(int[] nums)
        {
            int max = 0;
            List<List<double>> res = new List<List<double>>();
            var longs = nums.OrderBy(x => (double)x).ToArray();

            foreach (var l in longs)
            {
                foreach(var a in res)
                {
                    var cal = Math.Pow(a.Last(), 2);
                    if (cal > l) res.Remove(a);
                    else if (cal == l) res.Add(a);

                    max = Math.Max(max, a.Count);
                }
            }

            return max;
        }
    }
}