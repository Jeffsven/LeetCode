using System;

namespace _441._Arranging_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int input = 5;

            var res = new Solution().ArrangeCoins(input);
        }
    }
    public class Solution
    {
        public int ArrangeCoins(int n)
        {
            int count = 0;
            int starcase = 0;

            while (true)
            {
                starcase++;
                if (n < starcase) break;
                count++;
                n -= starcase;
            }

            return count;
        }
    }
}
