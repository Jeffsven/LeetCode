using System;
using System.Collections.Generic;
using System.Linq;

namespace _73._Set_Matrix_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[][]
            {
                new int[]{0,1,2,0},
                new int[]{3,4,5,2},
                new int[]{1,3,1,5},
            };

            new Solution().SetZeroes(input);

            foreach (var row in input)
            {
                Console.WriteLine($"[{string.Join(',', row)}]");
            }
        }
    }


    public class Solution
    {
        public void SetZeroes(int[][] matrix)
        {
            List<int> row = new List<int>();
            List<int> col = new List<int>();

            foreach (var r in matrix)
            {
                if (r.Where(x => x is 0).Select(x => x).Count() > 0)
                {
                    row.Add(Array.IndexOf(matrix, r));

                    for (int c = 0; c < r.Length; c++)
                    {
                        if (r[c] is 0) col.Add(c);
                    }
                }
            }

            for (int r = 0; r < matrix.Length; r++)
            {
                var r_arr = matrix[r];

                if (row.Contains(r)) matrix[r] = r_arr.Select(x => 0).ToArray();

                for (int c = 0; c < r_arr.Length; c++)
                {
                    if (col.Contains(c))
                    {
                        matrix[r][c] = 0;
                    }
                }
            }
        }
    }
}
