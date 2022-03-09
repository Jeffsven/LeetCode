using System;
using System.Linq;
using System.Collections.Generic;

namespace _1022._Sum_of_Root_To_Leaf_Binary_Numbers
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
        List<string> binary = new List<string>();

        public int SumRootToLeaf(TreeNode root)
        {
            


        }

        public void Recursive(TreeNode root, string s) 
        {

        }

    }
}
