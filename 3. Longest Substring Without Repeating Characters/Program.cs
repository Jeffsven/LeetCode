using System;

namespace _3._Longest_Substring_Without_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string problem = "estyrvfyyuyytfytvcbkjbwxdcvghjb";
            Solution sln = new Solution();
            int idx = sln.LengthOfLongestSubstring(problem);

            Console.WriteLine(problem);
            Console.WriteLine(idx);
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            string buffer = string.Empty;
            int length = 0;
            int counter = 0;
            int flag = 0;

            for (int i = flag ; i < s.Length; i++)
            {
                if (!buffer.Contains(s[i]))
                {
                    counter++;
                    buffer += s[i];
                }
                else
                {
                    length = Math.Max(length, counter);
                    counter = 0;
                    buffer = string.Empty;
                    i = flag++;
                }
            }
            length = Math.Max(length, counter);
            return length;
        }
    }
}
