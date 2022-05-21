using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _71._Simplify_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string path = "/a//b////c/d//././/..";

            var res = new Solution().SimplifyPath(path);
        }
    }

    public class Solution
    {
        public string SimplifyPath(string path)
        {
            var splits = path.Split("//");

            string ss = string.Empty;


            for (int i = splits.Length - 1; i >= 0; i--)
            {
                string s = splits[i];

                if (s is "." || s is ".." || s is "") continue;

                int lastslash = s.LastIndexOf('/');
                if (lastslash > 0) s = s.Substring(lastslash + 1);
                ss = "/" + s + ss;

                if (s.Contains('.')) break;
            }

            return ss;
        }
    }
}
