using System;
using System.Collections.Generic;
using System.Linq;

namespace _1178._Number_of_Valid_Words_for_Each_Puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string[] words = new string[] { "apple", "pleas", "please" };
            string[] puzzles = new string[] { "aelwxyz", "aelpxyz", "aelpsxy", "saelpxy", "xaelpsy" };

            var res = new Solution().FindNumOfValidWords(words, puzzles);
        }
    }

    //words = ["aaaa","asas","able","ability","actt","actor","access"],
    //puzzles = ["aboveyz","abrodyz","abslute","absoryz","actresz","gaswxyz"]

    public class Solution
    {
        public IList<int> FindNumOfValidWords(string[] words, string[] puzzles)
        {
            List<int> res = Enumerable.Range(0, puzzles.Length).Select(x => 0).ToList();

            var word_chars = words.Select(x => x.Distinct().ToArray()).ToList();

            for (int i = 0; i < puzzles.Length; i++)
            {
                int count = 0;

                foreach (var chars in word_chars)
                {
                    bool add = true;

                    foreach (var c in chars)
                    {
                        if (!puzzles[i].Contains(c) || !chars.Contains(puzzles[i][0]))
                        {
                            add = false;
                            break;
                        }
                    }
                    if (add) count++;
                }
                res[i] = count;
            }
            return res;
        }
    }
}
