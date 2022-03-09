using System;
using System.Linq;
using System.Collections.Generic;

namespace _382._Linked_List_Random_Node
{
    class Program
    {
        static void Main(string[] args)
        {
            var ln = Function.CreateListNode(new int[] { 10, 1, 10, 20, 100 });

            List<int> ress = new List<int>();
            int i = 0;
            while (i++ < 100)
            {
                ress.Add(new Solution(ln).GetRandom());
            }
        }
    }

    public class Solution
    {
        List<int> Values = new List<int>();

        public Solution(ListNode head)
        {
            while (head != null)
            {
                Values.Add(head.val);
                head = head.next;
            }
        }

        public int GetRandom()
        {
            return Values[new Random().Next(0, Values.Count )];
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Function
    {
        public static ListNode CreateListNode(int[] numbers)
        {
            numbers = numbers.Reverse().ToArray();
            ListNode ln = new ListNode(numbers[0]);

            for (int i = 1; i < numbers.Length; i++)
            {
                ln = new ListNode(numbers[i], ln);
            }

            return ln;
        }
    }
}
