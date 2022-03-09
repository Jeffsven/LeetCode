using System;
using System.Linq;
using System.Collections.Generic;


namespace _231._Power_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var res = new Solution().IsPowerOfTwo(3);
        }
    }

    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            var min = Math.Sqrt(Math.Pow(-2, 31));
            var max = (int)(Math.Pow(2, 31) - 2);
            var diff = max * 2;
            //var list = Enumerable.Range(min, max - min).Select(x => 2 ^ x).ToArray();


            return false;
        }
    }
}
