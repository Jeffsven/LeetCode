using System;
using System.Linq;
using System.Collections.Generic;

namespace _135._Candy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] ratings = new int[3] { 1, 0, 2 };

            int res = new Solution().Candy(ratings);
        }

        public class Solution
        {
            public int Candy(int[] ratings)
            {
                int sum = 0;
                int[] left2right = new int[ratings.Length];
                int[] right2left = new int[ratings.Length];
                Array.Fill(left2right, 1);
                Array.Fill(right2left, 1);

                for (int i = 1; i < ratings.Length; i++)
                {
                    if (ratings[i] > ratings[i - 1])
                    {
                        left2right[i] = left2right[i - 1] + 1;
                    }
                }
                for (int i = ratings.Length - 2; i >= 0; i--)
                {
                    if (ratings[i] > ratings[i + 1])
                    {
                        right2left[i] = right2left[i + 1] + 1;
                    }
                }
                for (int i = 0; i < ratings.Length; i++)
                {
                    sum += Math.Max(left2right[i], right2left[i]);
                }
                return sum;
            }
        }
    }
}
