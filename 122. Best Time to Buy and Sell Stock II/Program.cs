using System;
using System.Linq;
using System.Collections.Generic;

namespace _122._Best_Time_to_Buy_and_Sell_Stock_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] prices = new int[] { };

            var res = new Solution().MaxProfit(prices);
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int min = prices.Min();
            int max = prices.Max();


        }
    }
}
