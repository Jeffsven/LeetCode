using System;

namespace _450._Delete_Node_in_a_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
        //public TreeNode DeleteNode(TreeNode root, int key)
        //{
        //    if(root.val == key)
        //    {
        //        if(root.left!= null)
        //        {
        //            root = new TreeNode(root.left.val,root.)
        //        }
        //    }
        //}
    }
}
