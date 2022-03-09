using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;


namespace _520._Detect_Capital
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "mL";
            var res = new Solution().DetectCapitalUse(word);
        }
    }

    public class Solution
    {
        public bool DetectCapitalUse(string word)
        {
            if (word.Length is 1) return true;

            byte[] bytes = Encoding.ASCII.GetBytes(word);

            int min = 96;
            int lower = 0;

            bool isUpper = bytes[0] < min;

            for (int i = 1; i < word.Length; i++)
            {
                if (bytes[i] > min) lower++;
            }

            // all upper
            if (lower is 0) return isUpper;

            // all lower or with first upper
            if (lower == word.Length - 1) return true;

            return false;
        }
    }
}
