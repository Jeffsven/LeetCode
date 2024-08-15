using System;
using System.Linq;
using System.Collections.Generic;


namespace _997._Find_the_Town_Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int FindJudge(int n, int[][] trust)
        {
            var a = trust.Select(x => x[1]).ToArray();
            var b = a.GroupBy(x => x).Count();
            return b > 1 ? -1 : n;
        }
    }
}
