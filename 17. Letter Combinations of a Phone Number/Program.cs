using System;
using System.Linq;
using System.Collections.Generic;

namespace _17._Letter_Combinations_of_a_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var res = new Solution().LetterCombinations("23");
        }
    }

    public class Solution
    {
        int c = 97;
        List<List<string>> letters = new List<List<string>>();

        public Solution()
        {
            letters = new List<List<string>>()
            {
                Enumerable.Range(c,3).Select(x=>((char)x).ToString()).ToList(), //abc
                Enumerable.Range(c+=3,3).Select(x=>((char)x).ToString()).ToList(), //def
                Enumerable.Range(c+=3,3).Select(x=>((char)x).ToString()).ToList(), //ghi
                Enumerable.Range(c+=3,3).Select(x=>((char)x).ToString()).ToList(), //jkl
                Enumerable.Range(c+=3,3).Select(x=>((char)x).ToString()).ToList(), //mno
                Enumerable.Range(c+=3,4).Select(x=>((char)x).ToString()).ToList(), //pqrs
                Enumerable.Range(c+=4,3).Select(x=>((char)x).ToString()).ToList(), //tuv
                Enumerable.Range(c+=3,4).Select(x=>((char)x).ToString()).ToList(), //wxyz
            };
        }

        public IList<string> LetterCombinations(string digits)
        {
            var nums = digits.Select(x => int.Parse(x.ToString()) - 2).ToList();

            var selectedlist = new List<List<string>>();
            foreach (var n in nums) selectedlist.Add(letters[n]);

            List<string> result = new List<string>();

            #region
            switch (selectedlist.Count)
            {
                case 1: result.AddRange(selectedlist[0]); break;

                case 2:
                    {
                        foreach (var l1 in selectedlist[0])
                        {
                            foreach (var l2 in selectedlist[1])
                            {
                                result.Add(l1 + l2);
                            }
                        }
                    }
                    break;
                case 3:
                    {
                        foreach (var l1 in selectedlist[0])
                        {
                            foreach (var l2 in selectedlist[1])
                            {
                                foreach (var l3 in selectedlist[2])
                                {
                                    result.Add(l1 + l2 + l3);
                                }
                            }
                        }
                    }
                    break;
                case 4:
                    {
                        foreach (var l1 in selectedlist[0])
                        {
                            foreach (var l2 in selectedlist[1])
                            {
                                foreach (var l3 in selectedlist[2])
                                {
                                    foreach (var l4 in selectedlist[3])
                                    {
                                        result.Add(l1 + l2 + l3 + l4);
                                    }
                                }
                            }
                        }
                    }
                    break;
                default: break;
            }
            #endregion

            return result;

        }
    }
}

