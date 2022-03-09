using System;
using System.Collections.Generic;
using System.Linq;


namespace _1217._Minimum_Cost_to_Move_Chips_to_The_Same_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] inputs = new int[] { 1, 2, 3 };
            int res = new Solution().MinCostToMoveChips(inputs);
        }
    }

    public class Solution
    {
        public int MinCostToMoveChips(int[] position)
        {
            List<int> mincost = new List<int>();

            var pos = position.ToList();

            for (int i = 0; i < position.Length; i++)
            {
                var left = pos.GetRange(0, i);
                left.Reverse();

                var right = pos.GetRange(i + 1, position.Length - (i + 1));

                int leftcount = 0;
                left.RemoveAll(x => leftcount++ % 2 != 0);

                int rightcount = 0;
                right.RemoveAll(x => rightcount++ % 2 != 0);

                mincost.Add(left.Sum() + right.Sum());
            }

            var res = mincost.Min();
            return res;
        }
    }
}
