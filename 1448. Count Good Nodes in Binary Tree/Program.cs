using System;
using System.Linq;
using System.Collections.Generic;


namespace _1448._Count_Good_Nodes_in_Binary_Tree
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
        public int GoodNodes(TreeNode root)
        {
            int count = 0;

            

            if (root.left != null)
            {

            }
            if (root.right != null)
            {

            }
            return count;
        }
    }
}
