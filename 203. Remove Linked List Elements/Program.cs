using System;
using System.Linq;
using System.Collections.Generic;

namespace _203._Remove_Linked_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var head = new ListNode(1, new ListNode(2, new ListNode(6, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))));
            //head = new ListNode();
            var res = new Solution().RemoveElements(head, 6);
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
        public ListNode RemoveElements(ListNode head, int val)
        {
            List<int> elements = new List<int>();

            if (head is null) return null;

            while (head != null)
            {
                elements.Add(head.val);
                head = head.next;
            }

            elements.RemoveAll(x => x == val);

            if (elements.Count is 0) return null;

            ListNode value = new ListNode(elements.Last());
            for (int i = elements.Count - 1; i > 0; i--)
            {
                //value.val = elements[i];
                value = new ListNode(elements[i - 1], value);
            }
            return value;
        }
    }
}
