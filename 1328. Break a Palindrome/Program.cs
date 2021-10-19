using System;
using System.Linq;
using System.Collections.Generic;

namespace _1328._Break_a_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcccba";

            new Solution().BreakPalindrome(s);
        }
    }

    public class Solution
    {
        public string BreakPalindrome(string palindrome)
        {
            var input = palindrome.ToCharArray().ToList();
            int length = input.Count;
            int centre = length / 2;

            var inverseinput = input.GetRange(centre, length - centre);
            inverseinput.Reverse();

            char minChar = (char)(input.Select(x => (byte)x).Max());

            int target = 0;
            for(int i = 0; i < centre; i++)
            {
                if(input[i]!= inverseinput[i])
                {
                    target = i;
                    break;
                }
            }


            input[target] = 'a';

            return string.Join("", input);
        }
    }
}
