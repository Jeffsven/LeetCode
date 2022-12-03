using System;
using System.Linq;
using System.Collections.Generic;

namespace _76._Minimum_Window_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_s = "abc";
            string input_t = "cba";

            string output = new Solution().MinWindow(input_s, input_t);
            Console.WriteLine($"s={input_s}, t={input_t}");
            Console.WriteLine(output);
        }
    }


    public class Solution
    {
        //consist of upper case and lower case
        public string MinWindow(string s, string t)
        {
            string s1 = s;
            string s2 = s;

            var t_arr = t.ToCharArray();

            if (t.Length > s.Length) return string.Empty;
            if (s == t) return s;

            if (s.IndexOfAny(t_arr) == -1 && s.LastIndexOfAny(t_arr) == -1) return string.Empty;

            if (s.IndexOfAny(t_arr) == s.LastIndexOfAny(t_arr)) return t;

            //process
            string output1 = string.Empty;
            while (true)
            {
                int firstIdx = s1.IndexOfAny(t_arr);
                int lastidx = s1.LastIndexOfAny(t_arr);

                //substring
                s1 = s1.Substring(firstIdx, lastidx - firstIdx + 1);

                //check condition
                if (s1.ToList().Where(x => t_arr.Contains(x)).Count() < t.Length) break;

                //update
                output1 = s1;
                s1 = s1.Remove(lastidx, s1.Length - lastidx);
            }

            string output2 = string.Empty;
            while (true)
            {
                int firstIdx = s2.IndexOfAny(t_arr);
                int lastidx = s2.LastIndexOfAny(t_arr);

                //substring
                s2 = s2.Substring(firstIdx, lastidx - firstIdx + 1);

                //check condition
                if (s2.ToList().Where(x => t_arr.Contains(x)).Count() < t.Length) break;

                //update
                output2 = s2;
                s2 = s2.Remove(0, 1);
            }

            return new string[] { output1, output2 }[output1.Length > output2.Length ? 1 : 0];
        }
    }
}
