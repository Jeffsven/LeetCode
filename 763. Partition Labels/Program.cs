using System;
using System.Linq;
using System.Collections.Generic;

namespace _763._Partition_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string s = "eccbbbbdec";
            var res = new Solution().PartitionLabels(s);
        }
    }

    public class Solution
    {
        public IList<int> PartitionLabels(string s)
        {
            List<int> p = new List<int>();
            List<char> temps = new List<char>();

            while (s.Length != 0)
            {
                temps.Add(s[0]);
                s = s.Remove(0, 1);

                var idx = s.IndexOfAny(temps.ToArray());
                if (idx is -1)
                {
                    p.Add(temps.Count);
                    temps.Clear();
                }
            }

            return p;
        }
    }
}
