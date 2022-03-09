using System;
using System.Linq;

namespace _130._Surrounded_Regions
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new char[][]
            {
                new char[]{ 'X', 'X', 'X', 'X' },
                new char[]{ 'X', 'O', 'O', 'X' },
                new char[]{ 'X', 'X', 'O', 'X' },
                new char[]{ 'X', 'O', 'X', 'X' }
            };

            new Solution().Solve(input);
        }
    }

    public class Solution
    {
        public void Solve(char[][] board)
        {
            int row = board.Length;
            int col = board[0].Length;

            //initialize check jagged array
            bool[][] check = new bool[row][];
            for (int b = 0; b < check.Length; b++) check[b] = Enumerable.Range(0, col).Select(x => true).ToArray();

            const char X = 'X';
            const char O = 'O';

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (c is 0 || c == col - 1 || r is 0 || r == row - 1)
                    {
                        switch (board[r][c])
                        {
                            case X:
                                check[r][c] = false;
                                break;
                            case O:
                                {
                                    check[r][c] = false;

                                }
                                break;
                        }
                    }
                }
            }
        }
    }
}
