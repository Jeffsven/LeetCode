using System;
using System.Linq;
using System.Collections.Generic;

namespace _82._Remove_Duplicates_from_Sorted_List_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ListNode ln = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5)))))));

            var res = new Solution().DeleteDuplicates(ln);
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
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head is null) return head;

            List<int> nums = new List<int>();

            while (head != null)
            {
                nums.Add(head.val);
                head = head.next;
            }

            var b = nums.GroupBy(x => x);

            var c = b.Where(x => x.Count() is 1).Select(x => x.Key).OrderByDescending(x => x).ToList();


            ListNode ln = null;

            foreach(var d in c)
            {
                ln = new ListNode(d, ln);
            }

            return ln;
        }
    }
}
