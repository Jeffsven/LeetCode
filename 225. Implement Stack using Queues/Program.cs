using System;
using System.Linq;
using System.Collections.Generic;

namespace _225._Implement_Stack_using_Queues
{
    class Program
    {
        static void Main()
        {
            MyStack my = new MyStack();
            my.Push(0);
            my.Push(1);

        }

    }
    public class MyStack
    {
        List<int> S = new List<int>();
        public MyStack()
        {

        }

        public void Push(int x)
        {
            S.Insert(0, x);
        }

        public int Pop()
        {
            var n = S[0];
            S.RemoveAt(0);
            return n;
        }

        public int Top()
        {
            return S[0];
        }

        public bool Empty()
        {
            return S.Count is 0;
        }
    }

}
