using System;

namespace _7._Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = -71458145;
            int output = new Solution().Reverse(input);


            Console.WriteLine(input);
            Console.WriteLine(output);
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            bool negative = x < 0;
            if (negative) x *= -1;

            var s_in = x.ToString();
            var s_out = string.Empty;

            for (int i = s_in.Length - 1; i >= 0; i--)
            {
                s_out += s_in[i];
            }

            if (int.TryParse(s_out, out int res)) return negative ? res * -1 : res;
            return 0;
        }
    }
}
