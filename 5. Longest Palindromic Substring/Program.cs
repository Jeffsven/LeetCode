using System;

namespace _5._Longest_Palindromic_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "aaaa";

            string output = new Solution().LongestPalindrome(input);

            Console.WriteLine(input);
            Console.WriteLine(output);
        }
    }

    public class Solution
    {
        //adbdda
        //  - a
        //  a d
        //  d b

        public string LongestPalindrome(string s)
        {
            string s_centre = string.Empty;
            int i_centre = 0;

            string s_prev = string.Empty;
            string s_now = string.Empty;

            bool mirror = false;


            for(int i = 0; i < s.Length; i++)
            {
                s_prev = s_now;
                s_now = s[i].ToString();

                if (s_prev == s_now)
                {
                    if (string.IsNullOrEmpty(s_centre)) s_centre += s_prev + s_now;
                    else s_centre += s_now;
                }

            }
        }
    }
}
