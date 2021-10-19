using System;

namespace _463._Island_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new int[][]
            {
                new int[]{ 0, 1, 0, 0 },
                new int[]{ 1, 1, 1, 0 },
                new int[]{ 0, 1, 0, 0 },
                new int[]{ 1, 1, 0, 0 }
            };

            var result = new Solution().IslandPerimeter(input);
            Console.WriteLine(result);
        }
    }


    public class Solution
    {
        public int IslandPerimeter(int[][] grid)
        {
            int perimiter = 0;

            int col = grid[0].Length;
            int row = grid.Length;

            for (int c = 0; c < col; c++)
            {
                for (int r = 0; r < row; r++)
                {
                    if (grid[r][c] is 1)
                    {
                        int point = 4;

                        //filter condition

                        //up
                        if (r > 0)
                        {
                            if (grid[r - 1][c] is 1) point -= 1;
                        }
                        //down
                        if (r < row - 1)
                        {
                            if (grid[r + 1][c] is 1) point -= 1;
                        }
                        //left
                        if (c > 0)
                        {
                            if (grid[r][c - 1] is 1) point -= 1;
                        }
                        //right
                        if (c < col - 1)
                        {
                            if (grid[r][c + 1] is 1) point -= 1;
                        }

                        perimiter += point;
                    }
                }
            }


            return perimiter;
        }
    }
}
