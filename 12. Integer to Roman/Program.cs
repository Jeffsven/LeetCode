using System;

namespace _12._Integer_to_Roman
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 2156;
            var output = new Solution().IntToRoman(input);
            var output2 = new Solution2().IntToRoman(input);

            Console.WriteLine(input);
            Console.WriteLine(output);
            Console.WriteLine(output2);

        }
    }


    public class Solution
    {
        enum Symbol { I = 1, IV = 4, V = 5, IX = 9, X = 10, XL = 40, L = 50, XC = 90, C = 100, CD = 400, D = 500, CM = 900, M = 1000, }

        public string IntToRoman(int num)
        {
            string output = string.Empty;

            var symbol = Enum.GetValues(typeof(Symbol));
            Array.Reverse(symbol);

            foreach (Symbol n in symbol)
            {
                while (num >= (int)n)
                {
                    output += n;
                    num -= (int)n;
                }
            }


            return output;
        }
    }

    public class Solution2
    {
        public string IntToRoman(int num)
        {
            string[] thousand = new string[] { "", "M", "MM", "MMM", };
            string[] hundred = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] ten = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] one = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", };


            return thousand[num / 1000] + hundred[num % 1000 / 100] + ten[num % 100 / 10] + one[num % 10];
        }
    }
}
