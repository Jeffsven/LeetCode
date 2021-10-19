using System;
using System.Linq;
using System.Collections.Generic;


namespace _279._Perfect_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new Solution().NumSquares(12);
        }
    }
    public class Solution
    {
        List<int> perfectsquare = new List<int>();

        public Solution()
        {
            int i = 1;
            while (true)
            {
                int square = i * i;

                if (square > Math.Pow(10, 4)) break;

                perfectsquare.Add(square);
                i++;
            }
            perfectsquare = perfectsquare.OrderByDescending(x => x).ToList();
        }

        public int NumSquares(int n)
        {
            int count = 0;



            foreach (var no in perfectsquare)
            {
            _sdo:
                if (n >= no)
                {
                    n -= no;
                    count++;
                    if (n >= no) goto _sdo;
                }
                if (n is 0) break;
            }

            return count;
        }
    }
}
