using System;
using System.Linq;
using System.Collections.Generic;

namespace _284._Peeking_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class PeekingIterator
    {
        int[] Nums = new int[0];
        int Index = 0;

        // iterators refers to the first element of the array.
        public PeekingIterator(IEnumerator<int> iterator)
        {
            // initialize any member here.
            while (true)
            {
                Nums = Nums.Append(iterator.Current).ToArray();
                if (!iterator.MoveNext()) break;
            }
        }

        // Returns the next element in the iteration without advancing the iterator.
        public int Peek()
        {
            return Nums[Index];
        }

        // Returns the next element in the iteration and advances the iterator.
        public int Next()
        {
            return Nums[Index++];
        }

        // Returns false if the iterator is refering to the end of the array of true otherwise.
        public bool HasNext()
        {
            return Nums.Length > Index;
        }
    }
}
