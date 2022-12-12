namespace _124._Binary_Tree_Maximum_Path_Sum
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
        public int MaxPathSum(TreeNode root)
        {

        }
        void DeepSearch(TreeNode node)
        {
            if (node is null) return;
            DeepSearch(node.left);
            DeepSearch(node.right);
        }

    }
}