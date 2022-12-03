using System;
using System.Linq;
using System.Collections.Generic;

namespace _474._Ones_and_Zeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string[] strs = new string[] { "10", "0001", "111001", "1", "0" };
            int zero = 4;
            int one = 3;

            var res = new Solution().FindMaxForm(strs, zero, one);
        }
    }

    public class Solution
    {
        #region
        public class strObj
        {
            public string strs;
            public int zero;
            public int one;
            public strObj(string strs)
            {
                this.strs = strs;
                this.zero = strs.Where(x => x is '0').Count();
                this.one = strs.Where(x => x is '1').Count();
            }
            public override string ToString()
            {
                return strs;
            }
        }
        #endregion

        List<strObj> strObjs = new List<strObj>();
        public int FindMaxForm(string[] strs, int m, int n)
        {
            strObjs = strs.OrderBy(x=>x.Length).Select(x => new strObj(x)).ToList();

            var res = new List<strObj>();



            return res.Count;
        }
    }
}
