using System;
using System.Linq;
using System.Collections.Generic;

namespace _374._Guess_Number_Higher_or_Lower
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new Solution().GuessNumber(20);
        }
    }

    public class Solution
    {
        int pick = 5;

        public int GuessNumber(int n)
        {
            int min = 1;
            int max = n;

            if (min == max) return n;

            while (true)
            {
                int median = (min + max) / 2;

                //pick higher than guess
                if (guess(median) is 1)
                {
                    min = median;
                }
                //pick lower that guess
                else if (guess(median) is -1)
                {
                    max = median;
                }
                else
                {
                    return median;
                }
            }
        }


        int guess(int num)
        {
            if (pick < num) return -1;
            if (pick > num) return 1;
            return 0;
        }
    }
}
