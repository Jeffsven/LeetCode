using System;
using System.Linq;
using System.Collections.Generic;


namespace _1260._Shift_2D_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] grid = new int[][]
            //{
            //    new int[]{1,2,3},
            //    new int[]{4,5,6},
            //    new int[]{7,8,9},
            //};

            int[][] grid = new int[][]
            {
                new int[]{1},
                new int[]{2},
                new int[]{3},
                new int[]{4},
                new int[]{7},
                new int[]{6},
                new int[]{5},

            };

            var res = new Solution().ShiftGrid(grid, 100);
        }
    }

    public class Solution
    {
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            int row = grid.Length;
            int col = grid[0].Length;

            List<int> nolist = new List<int>();
            foreach (var nestlist in grid)nolist.AddRange(nestlist);
            k %= nolist.Count;

            var last = nolist.GetRange(nolist.Count - k, k);
            nolist.RemoveRange(nolist.Count - k, k);

            nolist.InsertRange(0, last);

            IList<IList<int>> res = new List<IList<int>>();

            for (int r = 0; r < row; r++)
            {
                var templist = nolist.GetRange(0, col);
                nolist.RemoveRange(0, col);
                res.Add(templist);
            }

            return res;
        }
    }
}
