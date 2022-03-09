using System;
using System.Linq;
using System.Collections.Generic;

namespace _21._Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            var res = new Solution().MergeTwoLists(l1, l2);
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
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            List<int> order = new List<int>();

            while (list1 != null)
            {
                order.Add(list1.val);
                list1 = list1.next;
            }

            while (list2 != null)
            {
                order.Add(list2.val);
                list2 = list2.next;
            }

            order = order.OrderByDescending(x => x).ToList();

            //recursive
            ListNode ln = null;
            foreach (var o in order)
            {
                ln = new ListNode(o, ln);
            }

            return ln;
        }
    }

    public class Solution2
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 is null) return list2;
            if (list2 is null) return list1;

            if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }

    }
}
