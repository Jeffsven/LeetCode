using System;
using System.IO;

namespace _29._Divide_Two_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = new Solution().Divide(-2147483648, -1);
        }
    }

    public class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend is 0) return 0;

            bool isdividendPos = dividend > 0;
            bool isdivisorPos = divisor > 0;

            bool isPos = isdividendPos == isdivisorPos;

            long res = 0;

            UInt64 udividend = (UInt64)Math.Abs((long)dividend);
            UInt64 udivisor = (UInt64)Math.Abs(divisor);

            while (true)
            {
                if (!((udividend -= udivisor) >= 0)) break;
                if (!(udividend <= UInt32.MaxValue)) break;
                res++;

            }

            return isPos ? (int)res : (int)-res;
        }
    }
}
