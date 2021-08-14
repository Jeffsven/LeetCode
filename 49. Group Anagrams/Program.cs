using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _49._Group_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            var ss = File.ReadAllText(@"C:\Users\Administrator\Desktop\leetcode.txt");
            var arr = ss.Split(new char[] { ',' });

            string[] input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat", "ever", "erv" };

            var output = new Solution().GroupAnagrams(arr);

            Console.WriteLine(string.Join(',', input));
        }
    }


    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Start();
            var a = strs.GroupBy(x => string.Concat(x.OrderBy(y => y)), x => x).Select(y => y.ToList() as IList<string>).ToList();
            var now = sw.ElapsedMilliseconds;

            return a;
        }
    }

    public class Solution2
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> slist = new List<IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                string s = strs[i];

                if (slist.Count is 0) slist.Add(new List<string>() { s });
                else
                {
                    bool unmatch = true;
                    foreach(var ls in slist)
                    {
                        if(decode(ls[0]) == decode(s))
                        {
                            ls.Add(s);
                            unmatch = false;
                            break;
                        }

                    }
                    if (unmatch)
                    {
                        slist.Add(new List<string>() { s });
                    }
                }

            }
            return slist;


            string decode(string s)
            {
                var c = s.ToCharArray();
                Array.Sort(c);
                return string.Join("", c);
            }

        }
    }
}
