using System;
using System.Linq;
using System.Collections.Generic;

namespace _258._Add_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 38;
            var res = new Solution().AddDigits(num);
        }
    }

    public class Solution
    {
        public int AddDigits(int num)
        {
            var nlist = num.ToString().Select(x => int.Parse(x.ToString())).ToList();

            while (nlist.Count > 1)
            {
                nlist = (num = nlist.Sum()).ToString().Select(x => int.Parse(x.ToString())).ToList();
            }

            return nlist[0];
        }
    }

    public class Solution2
    {
        public int AddDigits(int num)
        {
            return 1 + (num - 1) % 9;
        }
    }
}
