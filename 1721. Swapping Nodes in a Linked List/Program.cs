using System;
using System.Linq;
using System.Collections.Generic;

namespace _1721._Swapping_Nodes_in_a_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode ln = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            int[] values = new int[] { 1, 2, 3, 4, 5 };
            var res = new Solution().SwapNodes(ln, 2);
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

    public class Solution
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            //Convert listnide ot list<int>
            List<int> elements = new List<int>();

            if (head is null) return null;

            while (head != null)
            {
                elements.Add(head.val);
                head = head.next;
            }

            //Process
            var firstidx = k - 1;
            var lastidx = elements.Count - k;

            var first = elements[firstidx];
            var last = elements[lastidx];

            if (first != last)
            {
                elements.RemoveAt(firstidx);
                elements.Insert(firstidx, last);
                elements.RemoveAt(lastidx);
                elements.Insert(lastidx, first);
            }

            //Convert list<int> to listnode
            elements.Reverse();
            ListNode ln = null;
            foreach(var e in elements)
            {
                ln = new ListNode(e, ln); // recursive
            }
            return ln;
        }
    }
}
