using System;
using System.Linq;
using System.Collections.Generic;


namespace _705._Design_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            MyHashSet mhs = new MyHashSet();
            bool b;

            mhs.Add(1);
            mhs.Add(2);

            b = mhs.Contains(1);
            b = mhs.Contains(3);
            b = mhs.Contains(2);

            mhs.Add(2);
            mhs.Add(3);

            mhs.Remove(2);
            b = mhs.Contains(2);

        }
    }

    public class MyHashSet
    {
        int[] v;
        public MyHashSet()
        {
            v = Array.Empty<int>();
        }

        public void Add(int key)
        {
            if (v.Contains(key)) return;
            v = v.Append(key).ToArray();
        }

        public void Remove(int key)
        {
            v = v.Where(x => x != key).ToArray();
        }

        public bool Contains(int key)
        {
            return v.Contains(key);
        }
    }
}
