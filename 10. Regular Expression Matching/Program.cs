using System;

namespace _10._Regular_Expression_Matching
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            string p = "";

            bool output = new Solution().IsMatch(s, p);

            Console.WriteLine(s);
            Console.WriteLine(p);
            Console.WriteLine(output);
        }
    }



    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            string s1 = s;
            string p1 = p;


            for (int i = 0; i < s.Length; i++)
            {
                if (s1[i] == p1[i] || p1[i] == '.')
                {
                    
                }
            }




            return false;
        }
    }
}
