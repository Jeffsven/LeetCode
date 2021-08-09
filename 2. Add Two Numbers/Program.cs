using System;

namespace _2._Add_Two_Numbers
{
    class Program
    {
        //https://leetcode.com/problems/add-two-numbers/

        static void Main(string[] args)
        {
            Solution sln = new Solution();

            int[] arr1 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            int[] arr2 = new int[] { 5, 6, 4 };

            ListNode l1 = sln.GenerateListNode(arr1);
            ListNode l2 = sln.GenerateListNode(arr2);

            var res =  sln.AddTwoNumbers(l1, l2);
            var arr3 = sln.GerArrFromListNode(res);

            Console.WriteLine(string.Join(',', arr1));
            Console.WriteLine(string.Join(',', arr2));
            Console.WriteLine(string.Join(',', arr3));
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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string s1 = "";
            while (true)
            {
                s1 = l1.val + s1;
                if (l1.next is null) break;
                l1 = l1.next;
            }

            string s2 = "";
            while (true)
            {
                s2 = l2.val + s2;
                if (l2.next is null) break;
                l2 = l2.next;
            }

            var res = (System.Numerics.BigInteger.Parse(s1) + System.Numerics.BigInteger.Parse(s2)).ToString();

            ListNode ln = null;

            for (int i = 0; i < res.Length; i++)
            {
                ln = new ListNode(int.Parse(res[i].ToString()), ln);
            }

            return ln;
        }

        public ListNode GenerateListNode(params int[] arr)
        {
            ListNode ln = null;

            for (int i = 0; i < arr.Length; i++)
            {
                ln = new ListNode(arr[i], ln);
            }

            return ln;
        }

        public int [] GerArrFromListNode(ListNode ln)
        {
            string s = "";
            while (true)
            {
                s = ln.val + s;
                if (ln.next is null) break;
                ln = ln.next;
            }

            int[] arr = new int[s.Length];

            for(int i = 0; i < s.Length; i++)
            {
                arr[i] = int.Parse(s[i].ToString());
            }

            return arr;
        }
    }
}
