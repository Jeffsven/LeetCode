using System;

namespace _926._Flip_String_to_Monotone_Increasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int output = new Solution().MinFlipsMonoIncr(input);

            Console.WriteLine(input);
            Console.WriteLine(output);
        }
    }


    public class Solution
    {
        public int MinFlipsMonoIncr(string s)
        {
            int idx_0 = 0;
            int idx_1 = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] is '0') idx_0++;
                else idx_1++;
            }

        }
    }
}
