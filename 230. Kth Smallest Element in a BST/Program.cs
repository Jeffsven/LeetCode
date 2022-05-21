using System;
using System.Collections.Generic;
using System.Linq;

namespace _230._Kth_Smallest_Element_in_a_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
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
        List<int> val = new List<int>();

        public int KthSmallest(TreeNode root, int k)
        {
            AddList(root);
            val = val.OrderBy(x => x).ToList();
            return val[k - 1];
        }

        public void AddList(TreeNode root)
        {
            if (root is null) return;
            val.Add(root.val);
            AddList(root.left);
            AddList(root.right);
        }
    }
}
