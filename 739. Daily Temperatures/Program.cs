using System;
using System.Linq;
using System.Collections.Generic;

namespace _739._Daily_Temperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] inputs = new int[] { };
            var res = new Solution().DailyTemperatures(inputs);
        }
    }

    public class Solution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var temp = temperatures.ToList();
            int[] result = new int[temperatures.Length];

            int i = 0;
            while (true)
            {
                if (temp.Count is 0) break;

                var idx = temp.FindIndex(x => x > temp[0]);
                result[i++] = idx < 0 ? 0 : idx;
                temp.RemoveAt(0);
            }


            return result;
        }
    }
}
