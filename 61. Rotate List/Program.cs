using System;
using System.Linq;
using System.Collections.Generic;

namespace _61._Rotate_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode ln = new ListNode().FromArr(new int[] { 4, 8, -1, 0, 2 });

            var res = new Solution().RotateRight(ln, 13);
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

        public ListNode FromArr(int[] arr)
        {
            ListNode ln = null;
            //arr = arr.OrderByDescending(x => x).ToArray();
            arr = arr.Reverse().ToArray();

            foreach (int a in arr)
            {
                ln = new ListNode(a, ln);
            }
            return ln;
        }
    }

    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head is null) return head;

            List<int> no = new List<int>();

            while (head != null)
            {
                no.Add(head.val);
                head = head.next;
            }

            k %= no.Count;

            no.Reverse();

            for (int i = 0; i < k; i++)
            {
                var value = no[0];
                no.RemoveAt(0);
                no.Add(value);
            }


            ListNode ln = null;
            foreach (var n in no)
            {
                ln = new ListNode(n, ln);
            }
            return ln;
        }
    }
}
