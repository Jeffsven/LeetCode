using System.Linq;

namespace _328._Odd_Even_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            var res = new Solution().OddEvenList(null);
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
        public ListNode OddEvenList(ListNode head)
        {
            if (head is null) return head;

            List<int> final = new List<int>();

            do
            {
                if (final.Count % 2 is 0) final.Insert(final.Count / 2, head.val);
                else final.Add(head.val);
            }
            while ((head = head.next) != null);

            final.Reverse();

            ListNode res = null;
            foreach (var f in final) res = new ListNode() { val = f, next = res };
            return res;
        }
    }
}