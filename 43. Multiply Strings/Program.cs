using System;

namespace _43._Multiply_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string num1 = "";
            string num2 = "";

            var res = new Solution().Multiply(num1, num2);

        }
    }

    public class Solution
    {
        public string Multiply(string num1, string num2)
        {
            int n1 = int.Parse(num1);
            int n2 = int.Parse(num2);

            return (n1 * n2).ToString();
        }
    }
}
