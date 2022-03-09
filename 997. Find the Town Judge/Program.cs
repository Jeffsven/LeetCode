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
            var a = trust.SelectMany(x => x[1].ToString()).ToArray();
            return 1;
        }
    }
}
