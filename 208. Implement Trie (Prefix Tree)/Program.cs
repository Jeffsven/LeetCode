using System;
using System.Collections.Generic;
using System.Linq;

namespace _208._Implement_Trie__Prefix_Tree_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class Trie
    {
        List<string> Words = new List<string>();
        public Trie()
        {

        }

        public void Insert(string word)
        {
            Words.Add(word);
        }

        public bool Search(string word)
        {
            return Words.Contains(word);
        }

        public bool StartsWith(string prefix)
        {
            return Words.Where(x => x.StartsWith(prefix)).Count() > 0;
        }
    }

}
