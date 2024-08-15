namespace _206._Reverse_Linked_List
{

    public class Solution
    {
        ListNode ReverseHead;
        public ListNode ReverseList(ListNode head)
        {
            if (head is null) return ReverseHead;
            else
            {
                ReverseHead = new ListNode(head.val, ReverseHead);
                return ReverseList(head.next);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            new Solution().ReverseList();
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
}