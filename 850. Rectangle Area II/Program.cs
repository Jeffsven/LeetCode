using System;
using System.Linq;
using System.Collections.Generic;

namespace _850._Rectangle_Area_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Solution().RectangleArea(new int[][]
            {
                new int[]{ 0,0,1,3},
                new int[]{ 0,0,1,2},
                new int[]{ 0,0,2,3},
                new int[]{ 0,0,2,2},

            });
        }
    }



    public class Solution
    {

        public int RectangleArea(int[][] rectangles)
        {
            int x= rectangles.Length;
            int y = rectangles[0].Length;

            var TwoDimensionArr = new int[x, y];

            foreach (var arr in rectangles)
            {
                var startpos = arr.ToList().GetRange(0, 2);
                var endpos = arr.ToList().GetRange(2, 2);

                for (int row = startpos[0]; row < endpos[0]; row++)
                {
                    for (int col = startpos[1]; col < endpos[1]; col++)
                    {
                        TwoDimensionArr[row, col] = 1;
                    }
                }

            }
            return TwoDimensionArr.Cast<int>().Sum();
        }
    }
}
