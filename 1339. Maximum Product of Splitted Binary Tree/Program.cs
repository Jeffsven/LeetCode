using System.Collections.Generic;

namespace _1339._Maximum_Product_of_Splitted_Binary_Tree
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


        private static int c = 0;
        public static TreeNode CreateNode (int[] val)
        {
            TreeNode node = new TreeNode();
            node.left = new TreeNode(val[c++]);
            node.right = new TreeNode(val[c++]);


            return node;
        }
    }
    public class Solution
    {
        int mod = (int)1e9 + 7;

        public int MaxProduct(TreeNode root)
        {
            findSum(root);
            return (int)(findPro(root, root.val) % mod);
        }
        long findPro(TreeNode t, int sum)
        {
            if (t == null) { return 0; }
            return Math.Max(Math.Max(findPro(t.left, sum), findPro(t.right, sum)), (long)t.val * (sum - t.val));
        }
        void findSum(TreeNode node)
        {
            if (node is null) return;
            findSum(node.left);
            findSum(node.right);
            node.val += (node.left is null ? 0 : node.left.val) + (node.right is null ? 0 : node.right.val);
        }
    }
}