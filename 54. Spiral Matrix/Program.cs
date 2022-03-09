using System;
using System.Linq;
using System.Collections.Generic;


namespace _54._Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[][] input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };

            var res = new Solution().SpiralOrder(input);
        }
    }

    public class Solution
    {
        public List<int> SpiralOrder(int[][] matrix)
        {
            List<int> res = new List<int>();
            if (matrix.Length == 0 || matrix[0].Length == 0) return res;

            int top = 0;
            int bottom = matrix.Length - 1;
            int left = 0;
            int right = matrix[0].Length - 1;

            while (true)
            {
                for (int i = left; i <= right; i++) res.Add(matrix[top][i]);
                top++;
                if (left > right || top > bottom) break;

                for (int i = top; i <= bottom; i++) res.Add(matrix[i][right]);
                right--;
                if (left > right || top > bottom) break;

                for (int i = right; i >= left; i--) res.Add(matrix[bottom][i]);
                bottom--;
                if (left > right || top > bottom) break;

                for (int i = bottom; i >= top; i--) res.Add(matrix[i][left]);
                left++;
                if (left > right || top > bottom) break;
            }

            return res;
        }

    }
}
