using System;
using System.Linq;

namespace _151._Reverse_Words_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string input = "Alice does not even like bob";

            var res = new Solution().ReverseWords(input);
        }
    }

    public class Solution
    {
        public string ReverseWords(string s)
        {
            var sarr = s.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            return string.Join(" ", sarr);
        }
    }
}
