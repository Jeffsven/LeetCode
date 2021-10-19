using System;

namespace _993._Cousins_in_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        int leftnodedepth = 0;
        int rightnodedepth = 0;

        TreeNode leftparent = null;
        TreeNode rightparent = null;

        public bool IsCousins(TreeNode root, int x, int y)
        {
            GetDepthAndParent(root, x, y, 0, null);
            return leftnodedepth == rightnodedepth && leftparent != rightparent;
        }


        public void GetDepthAndParent(TreeNode root, int x, int y, int depth, TreeNode parent)
        {
            if (root == null) return;

            if (root.val == x)
            {
                leftparent = parent;
                leftnodedepth = depth;
            }
            else if (root.val == y)
            {
                rightparent = parent;
                rightnodedepth = depth;
            }

            GetDepthAndParent(root.left, x, y, depth + 1, root);
            GetDepthAndParent(root.right, x, y, depth + 1, root);
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
