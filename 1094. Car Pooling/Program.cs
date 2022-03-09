using System;
using System.Linq;
using System.Collections.Generic;

namespace _1094._Car_Pooling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[][] trips = new int[][] { new int[] { } };
            int capacity = 0; ;
            var res = new Solution().CarPooling(trips, capacity);
        }
    }

    public class Solution
    {
        public bool CarPooling(int[][] trips, int capacity)
        {
            int cumulative_passenger = 0;

            int[] start = trips.Select(x => x[0]).ToArray();
            int[] stop = trips.Select(x => x[0]).ToArray();

            for (int i = 0; i < trips.Length; i++)
            {

            }
        }
    }
}
