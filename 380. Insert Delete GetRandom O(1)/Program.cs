using System;
using System.Linq;
using System.Collections.Generic;

namespace _380._Insert_Delete_GetRandom_O_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 0;

            RandomizedSet obj = new RandomizedSet();
            bool param_1 = obj.Insert(val);
            bool param_2 = obj.Remove(val);
            int param_3 = obj.GetRandom();
        }
    }

    public class RandomizedSet
    {
        List<int> Val_list;

        public RandomizedSet()
        {
            Val_list = new List<int>();
        }

        public bool Insert(int val)
        {
            bool insert = !Val_list.Contains(val);
            if (insert) Val_list.Add(val);
            return insert;
        }

        public bool Remove(int val)
        {
            bool remove = Val_list.Contains(val);
            if (remove) Val_list.Remove(val);
            return remove;
        }

        public int GetRandom()
        {
            var rdm = new Random().Next(0, Val_list.Count);
            return Val_list[rdm];
        }
    }

    //["RandomizedSet", "insert",   "insert",   "insert",   "getRandom",    "insert",   "remove",   "getRandom",    "insert",   "getRandom",    "insert"]
    //[[],              [0],        [0],        [2],        [],             [3],        [1],        [],             [3],        [],             [2]]
}
