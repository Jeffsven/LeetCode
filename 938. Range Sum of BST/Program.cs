namespace _938._Range_Sum_of_BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        int sum = 0;

        public int RangeSumBST(TreeNode root, int low, int high)
        {
            DeepSearch(root, low, high);
            return sum;
        }


        public void DeepSearch(TreeNode node, int low, int high)
        {
            if (node is null) return;
            if (node.val >= low && node.val <= high) sum += node.val;
            DeepSearch(node.left, low, high);
            DeepSearch(node.right, low, high);
        }
    }
}