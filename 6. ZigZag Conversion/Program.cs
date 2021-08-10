using System;

namespace _6._ZigZag_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "PAYPALISHIRING";
            int row = 3;
            string output = new Solution().Convert(input, row);

            Console.WriteLine(input);
            Console.WriteLine(row);
            Console.WriteLine(output);

        }
    }

    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows is 1) return s;

            string[,] arr_2d = new string[s.Length, numRows];

            bool reverse = false;

            int c = 0;

            for (int i = 0; i < s.Length; i++)
            {
                string svalue = s[i].ToString();
                arr_2d[i, c] = svalue;

                reverse = reverse ? c > 0 : c == numRows - 1;
                if (reverse) c--; else c++;
            }

            string output = string.Empty;

            for (int j = 0; j < numRows; j++)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    output += arr_2d[i, j];
                }
            }



            return output;
        }
    }
}
