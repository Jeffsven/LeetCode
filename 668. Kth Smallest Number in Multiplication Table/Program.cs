using System;
using System.Linq;
using System.Collections.Generic;

namespace _668._Kth_Smallest_Number_in_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var res = new Solution().FindKthNumber(9895, 28405, 100787757);
        }
    }


    public class Solution
    {
        public int FindKthNumber(int m, int n, int k)
        {
            List<int> dd = new List<int>();

            List<List<int>> ef = new List<List<int>>();

            for (int c = 0; c < n; c++)
            {
                for (int r = 0; r < m; r++)
                {
                    var dq = (c + 1) * (r + 1);

                    //ef.Find()
                }
            }

            dd = dd.OrderBy(x => x).ToList();

            int res = dd[k - 1];
            return res;
        }
    }
}
