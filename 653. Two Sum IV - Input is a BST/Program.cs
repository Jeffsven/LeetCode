using System;
using System.Linq;
using System.Collections.Generic;

namespace _653._Two_Sum_IV___Input_is_a_BST
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
        HashSet<int> Value = new HashSet<int>();

        public bool FindTarget(TreeNode root, int k)
        {
            Value.Add(root.val);

            if (root.left != null)
            {
                foreach (var value in Value)
                {
                    if (value + root.left.val == k) return true;
                }
                return FindTarget(root.left, k);
            }
            if (root.right != null)
            {
                foreach (var value in Value)
                {
                    if (value + root.right.val == k) return true;
                }
                return FindTarget(root.right, k);
            }
            return false;
        }
    }
}
