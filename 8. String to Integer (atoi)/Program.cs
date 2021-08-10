using System;

namespace _8._String_to_Integer__atoi_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = ".1";
            int output = new Solution().MyAtoi(input);

            Console.WriteLine(input);
            Console.WriteLine(output);
        }
    }

    public class Solution
    {
        public int MyAtoi(string s)
        {
            bool reading = false;
            int output = 0;
            string svalue = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];

                if (!reading) 
                {
                    if (char.IsDigit(c) || c is '+' || c is '-') svalue += c;
                    if (c is '.') break;
                    if (char.IsLetter(c)) break;
                    reading = svalue.Length > 0;
                } 
                else
                {
                    if (!char.IsDigit(c)) break;
                    else svalue += c;
                }
            }

            if (System.Numerics.BigInteger.TryParse(svalue, out System.Numerics.BigInteger res))
            {
                if (res > 0) output = res > int.MaxValue ? int.MaxValue : (int)res;
                else output = res < int.MinValue ? int.MinValue : (int)res;
            }

            return output;
        }
    }
}
