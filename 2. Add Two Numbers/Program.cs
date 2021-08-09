using System;

namespace _2._Add_Two_Numbers
{
    class Program
    {
        //https://leetcode.com/problems/add-two-numbers/

        static void Main(string[] args)
        {
            Solution sln = new Solution();

            int[] arr1 = new int[] { 2, 4, 3 };
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
            int[] arr1 = new int[0];
            int[] arr2 = new int[0];

            int i1 = 0;
            while (true)
            {
                Array.Resize(ref arr1, i1 + 1);
                arr1[i1++] = l1.val;

                if (l1.next is null) break;
                l1 = l1.next;
            }

            int i2 = 0;
            while (true)
            {
                Array.Resize(ref arr2, i2 + 1);
                arr2[i2++] = l2.val;

                if (l2.next is null) break;
                l2 = l2.next;
            }

            int maxLength = Math.Max(arr1.Length, arr2.Length);
            Array.Resize(ref arr1, maxLength);
            Array.Resize(ref arr2, maxLength);

            int[] arr3 = new int[maxLength];
            int carry = 0;

            for (int i = 0; i < arr3.Length; i++)
            {
                var value = arr1[i] + arr2[i] + carry;
                carry = 0;
                if (value >= 10)
                {
                    carry = 1;
                    value -= 10;
                }
                arr3[i] = value;
            }

            if(carry is 1)
            {
                Array.Resize(ref arr3, maxLength + 1);
                arr3[maxLength] = 1;
            }


            ListNode ln = null;

            for (int i = arr3.Length - 1; i >= 0; i--)
            {
                ln = new ListNode(arr3[i], ln);
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
