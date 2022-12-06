namespace _876._Middle_of_the_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    public class Solution
    {
        List<ListNode> listNodes = new List< ListNode>();
        public ListNode MiddleNode(ListNode head)
        {
            do listNodes.Add(head);
            while ((head = head.next) != null);

            return listNodes[listNodes.Count / 2];
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