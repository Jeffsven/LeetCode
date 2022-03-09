using System;
using System.Collections.Generic;
using System.Linq;


namespace _141._Linked_List_Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ListNode ln = new ListNode(0);

            var res = new Solution().HasCycle(ln);

        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        List<int> nums = new List<int>();

        public bool HasCycle(ListNode head)
        {
            if (head is null) return false;
            else
            {
                if (nums.Contains(head.val)) return true;
                nums.Add(head.val);
                head = head.next;

                return HasCycle(head);
            }
        }
    }
}
