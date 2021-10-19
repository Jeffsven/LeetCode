using System;

namespace _79._Word_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var chargird = new char[][] { };
            string word = "";

            bool res = new Solution().Exist(chargird, word);
        }
    }

    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            int col = board[0].Length;
            int row = board.Length;

            for (int c = 0; c < col; c++)
            {
                for (int r = 0; r < row; r++)
                {
                    if (board[c][r] == word[0])
                    {

                    }
                }
            }
        }
    }
}
