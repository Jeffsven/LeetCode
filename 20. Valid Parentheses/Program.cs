using System;

namespace _20._Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var res = new Solution().IsValid("()");
        }
    }

    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length is 1) return false;

            char prev_c;

            foreach (var c in s)
            {
                switch (c)
                {
                    case ')': if (c != '(') return false; break;
                    case ']': if (c != '[') return false; break;
                    case '}': if (c != '{') return false; break;
                }
                prev_c = c;
            }
            return true;
        }
    }
}
