using System;
using System.Linq;
using System.Collections.Generic;


namespace _543._Diameter_of_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode main = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3));

            var res = new Solution().DiameterOfBinaryTree(main);
        }
    }

    public class Solution
    {
        int max = 0;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            maxDepth(root);
            return max;
        }

        private int maxDepth(TreeNode root)
        {
            if (root == null) return 0;

            int left = maxDepth(root.left);
            int right = maxDepth(root.right);

            max = Math.Max(max, left + right);

            return Math.Max(left, right) + 1;
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
}
